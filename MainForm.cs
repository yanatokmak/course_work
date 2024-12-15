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

            // Всплывающее окно для выбора действия при запуске программы
            DialogResult result = MessageBox.Show("Хотите загрузить сохраненный список сотрудников?", "Загрузка данных", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Если пользователь нажал Да, загружаем сотрудников из файла
                LoadEmployees();
            }
            else
            {
                // Если пользователь нажал Нет, создаем пустой список сотрудников
                employees = new List<Employee>();
            }

            // Привязываем обработчики событий
            buttonAdd.Click += buttonAdd_Click;
            buttonDeleteEmployee.Click += buttonDeleteEmployee_Click;
            buttonEditEmployee.Click += buttonEditEmployee_Click;
        }

        // Метод для загрузки списка сотрудников
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
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
            else
            {
                employees = new List<Employee>(); // Если файл не найден, создаем новый список
            }
        }

        // Метод для сохранения списка сотрудников
        private void SaveEmployees()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employees.json");

            try
            {
                string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
                File.WriteAllText(filePath, json);
                MessageBox.Show("Данные успешно сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        // Обработчик кнопки добавления нового сотрудника
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (AddEmployeeForm newForm = new AddEmployeeForm())
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    Employee newEmployee = newForm.CreateEmployee(); // Получаем нового сотрудника из формы
                    employees.Add(newEmployee);
                    listBoxEmployees.Items.Add($"{newEmployee.Surname} {newEmployee.Name} {newEmployee.Patronymic}");
                    listBoxEmployees.Refresh();
                    SaveEmployees(); // Сохраняем обновленный список сотрудников
                }
            }
        }

        // Обработчик кнопки удаления сотрудника
        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex == -1) return;

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранного сотрудника?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = listBoxEmployees.SelectedIndex;
                employees.RemoveAt(index);
                listBoxEmployees.Items.RemoveAt(index);
                listBoxEmployees.Refresh();
                SaveEmployees(); // Сохраняем обновленный список сотрудников
            }
        }

        // Обработчик кнопки редактирования сотрудника
        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    SaveEmployees(); // Сохраняем обновленный список сотрудников
                }
            }
        }

        // Обработчик закрытия формы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Хотите сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SaveEmployees(); // Сохраняем список сотрудников перед выходом
            }
        }
    }
}
