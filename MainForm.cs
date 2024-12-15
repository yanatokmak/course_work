using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace course_work
{
    public partial class MainForm : Form
    {
        private List<Employee> employees = new List<Employee>();

        public MainForm()
        {
            InitializeComponent();

            // ����������� ���� ��� ������ �������� ��� ������� ���������
            DialogResult result = MessageBox.Show("������ ��������� ����������� ������ �����������?", "�������� ������", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // ���� ������������ ����� ��, ��������� ����������� �� �����
                LoadEmployees();
            }
            else
            {
                // ���� ������������ ����� ���, ������� ������ ������ �����������
                employees = new List<Employee>();
            }

            // ����������� ����������� �������
            buttonAdd.Click += buttonAdd_Click;
            buttonDeleteEmployee.Click += buttonDeleteEmployee_Click;
            buttonEditEmployee.Click += buttonEditEmployee_Click;
        }

        // ����� ��� �������� ������ �����������
        private void LoadEmployees()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employees.json");

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    employees = JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
                    listBoxEmployees.Items.Clear();
                    foreach (var employee in employees)
                    {
                        listBoxEmployees.Items.Add(employee.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� �������� ������: " + ex.Message);
                }
            }
            else
            {
                employees = new List<Employee>(); // ���� ���� �� ������, ������� ����� ������
            }
        }

        // ����� ��� ���������� ������ �����������
        private void SaveEmployees()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employees.json");

            try
            {
                string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
                File.WriteAllText(filePath, json);
                MessageBox.Show("������ ������� ���������.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ���������� ������: " + ex.Message);
            }
        }

        // ���������� ������ ���������� ������ ����������
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (AddEmployeeForm newForm = new AddEmployeeForm())
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    Employee newEmployee = newForm.CreateEmployee(); // �������� ������ ���������� �� �����
                    employees.Add(newEmployee);
                    listBoxEmployees.Items.Add($"{newEmployee.Surname} {newEmployee.Name} {newEmployee.Patronymic}");
                    listBoxEmployees.Refresh();
                    SaveEmployees(); // ��������� ����������� ������ �����������
                }
            }
        }

        // ���������� ������ �������� ����������
        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex == -1) return;

            var result = MessageBox.Show("�� �������, ��� ������ ������� ���������� ����������?",
                "������������� ��������", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = listBoxEmployees.SelectedIndex;
                employees.RemoveAt(index);
                listBoxEmployees.Items.RemoveAt(index);
                listBoxEmployees.Refresh();
                SaveEmployees(); // ��������� ����������� ������ �����������
            }
        }

        // ���������� ������ �������������� ����������
        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("����������, �������� ���������� ��� ��������������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedEmployee = employees[listBoxEmployees.SelectedIndex];
            using (AddEmployeeForm editForm = new AddEmployeeForm(selectedEmployee))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    employees[listBoxEmployees.SelectedIndex] = editForm.currentEmployee;
                    listBoxEmployees.Items[listBoxEmployees.SelectedIndex] = $"{editForm.currentEmployee.Surname} {editForm.currentEmployee.Name} {editForm.currentEmployee.Patronymic}";
                    listBoxEmployees.Refresh();
                    SaveEmployees(); // ��������� ����������� ������ �����������
                }
            }
        }

        // ���������� �������� �����
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("������ ��������� ���������?", "�������������", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SaveEmployees(); // ��������� ������ ����������� ����� �������
            }
        }
    }
}
