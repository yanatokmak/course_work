using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;  
using System.IO;
using static course_work.Employee;
using static course_work.GeneralInfo;

namespace course_work
{
    public partial class AddEmployeeForm : Form
    {
        private int currentPanelIndex = 0;
        private Panel[] panels;
        private bool errorShown = false;
        private List<Education> educations = new List<Education>();
        private List<PreviousJob> previousJobs = new List<PreviousJob>();
        private List<JobMovement> jobMovements = new List<JobMovement>();
        private List<Measure> disciplinaryActions = new List<Measure>();
        private List<Measure> incentives = new List<Measure>();
        public Employee currentEmployee;

        public AddEmployeeForm(Employee employee = null)
        {
            InitializeComponent();
            InitializePanels();
            ShowPanel(currentPanelIndex);
            buttonNext.Click += buttonNext_Click;
            buttonBack.Click += buttonBack_Click;
            buttonAddPhoto.Click += buttonAddPhoto_Click;
            buttonAddEducation.Click += buttonAddEducation_Click;
            buttonDeleteEducation.Click += buttonDeleteEducation_Click;
            buttonAddPreviousJob.Click += buttonAddPreviousJob_Click;
            buttonDeletePreviousJob.Click += buttonDeletePreviousJob_Click;
            buttonAddJobMovement.Click += buttonAddJobMovement_Click;
            buttonDeleteJobMovement.Click += buttonDeleteJobMovement_Click;
            buttonAddDisciplinaryAction.Click += buttonAddDisciplinaryAction_Click;
            buttonDeleteDisciplinaryAction.Click += buttonDeleteDisciplinaryAction_Click;
            buttonAddIncentive.Click += buttonAddIncentive_Click;
            buttonDeleteIncentive.Click += buttonDeleteIncentive_Click;
            buttonSave.Click += buttonSave_Click;

            listBoxEducations.DoubleClick += listBoxEducations_DoubleClick;
            listBoxPreviousJobs.DoubleClick += listBoxPreviousJobs_DoubleClick;
            listBoxJobMovements.DoubleClick += listBoxJobMovements_DoubleClick;
            listBoxDisciplinaryActions.DoubleClick += listBoxDisciplinaryActions_DoubleClick;
            listBoxIncentives.DoubleClick += listBoxIncentives_DoubleClick;

            currentEmployee = employee;
            if (employee != null)
            {
                LoadEmployeeData(employee);
            }
        }

        private void InitializePanels()
        {
            panels = new Panel[] {
            panelGeneralInfo,
            panelEducation,
            panelJobHistory,
            panelJobMovement,
            panelDisciplinaryAction,
            panelIncentive
        };
        }

        private void ShowPanel(int index)
        {
            foreach (var panel in panels)
            {
                panel.Visible = false;
            }

            panels[index].Visible = true;

            buttonBack.Visible = currentPanelIndex > 0;
            buttonNext.Visible = currentPanelIndex < panels.Length - 1;
            buttonSave.Visible = currentPanelIndex == panels.Length - 1;
            errorShown = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!AreCurrentPanelFieldsFilled())
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля перед переходом на следующую вкладку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateCurrentPanelFields())
            {
                return;
            }

            if (currentPanelIndex < panels.Length - 1)
            {
                currentPanelIndex++;
                ShowPanel(currentPanelIndex);
            }
            else
            {
                if (!errorShown)
                {
                    MessageBox.Show("Пожалуйста, заполните все обязательные поля перед переходом на следующую вкладку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorShown = true;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentPanelIndex > 0)
            {
                currentPanelIndex--;
                ShowPanel(currentPanelIndex);
            }
        }

        private string photoPath = ""; // Переменная для хранения пути к фото

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Выберите фотографию";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Путь к выбранному файлу
                    string sourcePath = openFileDialog.FileName;

                    // Получаем имя файла
                    string fileName = Path.GetFileName(sourcePath);

                    // Путь назначения — папка Photos в каталоге программы
                    string destinationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Photos", fileName);

                    try
                    {
                        // Копируем файл в папку Photos (перезаписываем, если файл уже существует)
                        File.Copy(sourcePath, destinationPath, true);

                        // Загружаем фото в PictureBox
                        pictureBoxPhoto.Image = Image.FromFile(destinationPath);

                        // Сохраняем путь к файлу
                        photoPath = destinationPath;

                        MessageBox.Show("Фото добавлено и сохранено.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении фото: " + ex.Message);
                    }
                }
            }
        }


        private void buttonAddEducation_Click(object sender, EventArgs e)
        {
            var window = new EducationForm();
            if (window.ShowDialog() == DialogResult.OK)
            {
                var newEducation = window.Education;
                educations.Add(newEducation);
                listBoxEducations.Items.Add(newEducation.ToString());
            }
        }

        private void buttonDeleteEducation_Click(object sender, EventArgs e)
        {
            if (listBoxEducations.SelectedIndex == -1) return;

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранное образование?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = listBoxEducations.SelectedIndex;
                educations.RemoveAt(index);
                listBoxEducations.Items.RemoveAt(index);

                // Обновление интерфейса
                listBoxEducations.Refresh();
            }
        }

        private void buttonAddPreviousJob_Click(object sender, EventArgs e)
        {
            var window = new PreviousJobForm();
            if (window.ShowDialog() == DialogResult.OK)
            {
                var newPreviousJob = window.PreviousJob;
                previousJobs.Add(newPreviousJob);
                listBoxPreviousJobs.Items.Add(newPreviousJob.ToString());
            }
        }

        private void buttonDeletePreviousJob_Click(object sender, EventArgs e)
        {
            if (listBoxPreviousJobs.SelectedIndex == -1) return;

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранное предыдущее место работы?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = listBoxPreviousJobs.SelectedIndex;
                previousJobs.RemoveAt(index);
                listBoxPreviousJobs.Items.RemoveAt(index);

                // Обновление интерфейса
                listBoxPreviousJobs.Refresh();
            }
        }

        private void buttonAddJobMovement_Click(object sender, EventArgs e)
        {
            var window = new JobMovementForm();
            if (window.ShowDialog() == DialogResult.OK)
            {
                var newJobMovement = window.JobMovement;
                jobMovements.Add(newJobMovement);
                listBoxJobMovements.Items.Add(newJobMovement.ToString());
            }
        }

        private void buttonDeleteJobMovement_Click(object sender, EventArgs e)
        {
            if (listBoxJobMovements.SelectedIndex == -1) return;

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранное перемещение по работе?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = listBoxJobMovements.SelectedIndex;
                jobMovements.RemoveAt(index);
                listBoxJobMovements.Items.RemoveAt(index);

                // Обновление интерфейса
                listBoxJobMovements.Refresh();
            }
        }

        private void buttonAddDisciplinaryAction_Click(object sender, EventArgs e)
        {
            var window = new DisciplinaryActionForm();
            if (window.ShowDialog() == DialogResult.OK)
            {
                var newDisciplinaryAction = window.Measure;
                disciplinaryActions.Add(newDisciplinaryAction);
                listBoxDisciplinaryActions.Items.Add(newDisciplinaryAction.ToString());
            }
        }

        private void buttonDeleteDisciplinaryAction_Click(object sender, EventArgs e)
        {
            if (listBoxDisciplinaryActions.SelectedIndex == -1) return;

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранное дисциплинарное взыскание?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = listBoxDisciplinaryActions.SelectedIndex;
                disciplinaryActions.RemoveAt(index);
                listBoxDisciplinaryActions.Items.RemoveAt(index);

                // Обновление интерфейса
                listBoxDisciplinaryActions.Refresh();
            }
        }

        private void buttonAddIncentive_Click(object sender, EventArgs e)
        {
            var window = new IncentiveForm();
            if (window.ShowDialog() == DialogResult.OK)
            {
                var newIncentive = window.Measure;
                incentives.Add(newIncentive);
                listBoxIncentives.Items.Add(newIncentive.ToString());
            }
        }

        private void buttonDeleteIncentive_Click(object sender, EventArgs e)
        {
            if (listBoxIncentives.SelectedIndex == -1) return;

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранное поощрительное действие?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = listBoxIncentives.SelectedIndex;
                incentives.RemoveAt(index);
                listBoxIncentives.Items.RemoveAt(index);

                // Обновление интерфейса
                listBoxIncentives.Refresh();
            }
        }

        private bool AreGeneralInfoFieldsFilled()
        {
            return pictureBoxPhoto.Image != null &&
                   !string.IsNullOrWhiteSpace(textBoxSurname.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxName.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxPlaceOfBirth.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxHomeAddress.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxPassportNumber.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxIssuedBy.Text);
        }

        private bool ValidateGeneralInfoFields()
        {
            bool isValid = true;

            try
            {
                if (pictureBoxPhoto.Image == null)
                {
                    throw new ArgumentException("Пожалуйста, добавьте фотографию.");
                }

                Validation.ValidateNoDigits(textBoxSurname.Text, "Фамилия");
                Validation.ValidateNoDigits(textBoxName.Text, "Имя");
                if (!string.IsNullOrWhiteSpace(textBoxPatronymic.Text))
                {
                    Validation.ValidateNoDigits(textBoxPatronymic.Text, "Отчество");
                }
                Validation.ValidateDateNotInFuture(pickerDateOfBirth.Value, "Дата рождения");
                Validation.ValidateAlphabetOnly(textBoxPlaceOfBirth.Text, "Место рождения");
                Validation.ValidateLength(textBoxPhoneNumber.Text, "Телефон", 3, 10);
                Validation.ValidateOnlyDigits(textBoxPassportNumber.Text, "Номер паспорта", 6);
                Validation.ValidateDateNotInFuture(pickerDateOfIssue.Value, "Дата выдачи");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }

        private bool AreEducationFieldsFilled()
        {
            // Проверка, что listBoxEducations не пустой
            if (listBoxEducations.Items.Count == 0)
            {
                return false;
            }

            // Проверка полей для класса Employee
            if (string.IsNullOrWhiteSpace(comboBoxAcademicDegree.Text) ||
                string.IsNullOrWhiteSpace(comboBoxAcademicTitle.Text))
            {
                return false;
            }

            return true;
        }

        private bool ArePreviousJobsFieldsFilled()
        {
            // Проверка, что listBoxPreviousJobs не пустой
            if (listBoxPreviousJobs.Items.Count == 0)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxDepartment.Text) ||
                string.IsNullOrWhiteSpace(textBoxPosition.Text) ||
                pickerEmploymentStartDate.Value == null)
            {
                return false;
            }

            return true;
        }

        private bool IsListBoxFilled(ListBox listBox)
        {
            return listBox != null && listBox.Items.Count > 0;
        }

        private bool AreCurrentPanelFieldsFilled()
        {
            switch (currentPanelIndex)
            {
                case 0:
                    return AreGeneralInfoFieldsFilled();
                case 1:
                    return AreEducationFieldsFilled();
                case 2:
                    return ArePreviousJobsFieldsFilled();
                case 3:
                    return IsListBoxFilled(listBoxJobMovements);
                case 4:
                case 5:
                    return true;
                default:
                    return false;
            }
        }

        private bool ValidateCurrentPanelFields()
        {
            switch (currentPanelIndex)
            {
                case 0:
                    return ValidateGeneralInfoFields();
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return true;
                default:
                    return false;
            }
        }

        public Employee CreateEmployee()
        {
            return new Employee(
                photoPath,
                textBoxSurname.Text,
                textBoxName.Text,
                textBoxPatronymic.Text,
                textBoxPhoneNumber.Text,
                textBoxPassportNumber.Text,
                pickerDateOfBirth.Value,
                textBoxPlaceOfBirth.Text,
                textBoxHomeAddress.Text,
                pickerDateOfIssue.Value,
                textBoxIssuedBy.Text,
                comboBoxGender.Text,
                textBoxDepartment.Text,
                textBoxPosition.Text,
                pickerEmploymentStartDate.Value,
                comboBoxAcademicDegree.Text,
                comboBoxAcademicTitle.Text,
                incentives,
                disciplinaryActions,
                previousJobs,
                educations,
                jobMovements
            );
        }

        private void LoadEmployeeData(Employee employee)
        {
            if (!string.IsNullOrEmpty(employee.PhotoPath) && File.Exists(employee.PhotoPath))
            {
                pictureBoxPhoto.Image = Image.FromFile(employee.PhotoPath);
            }
            else
            {
                pictureBoxPhoto.Image = null; // Если путь некорректен, очищаем PictureBox
            }

            textBoxSurname.Text = employee.Surname;
            textBoxName.Text = employee.Name;
            textBoxPatronymic.Text = employee.Patronymic;
            textBoxPhoneNumber.Text = employee.PhoneNumber;
            textBoxPassportNumber.Text = employee.PassportNumber;
            pickerDateOfBirth.Value = employee.DateOfBirth;
            textBoxPlaceOfBirth.Text = employee.PlaceOfBirth;
            textBoxHomeAddress.Text = employee.HomeAddress;
            pickerDateOfIssue.Value = employee.PassportIssueDate;
            textBoxIssuedBy.Text = employee.PassportIssuedBy;
            comboBoxGender.Text = employee.Gender;
            textBoxDepartment.Text = employee.Department;
            textBoxPosition.Text = employee.Position;
            pickerEmploymentStartDate.Value = employee.EmploymentStartDate;
            comboBoxAcademicDegree.Text = employee.Degree;
            comboBoxAcademicTitle.Text = employee.Title;

            // Загрузка данных в ListBox
            educations = employee.Educations;
            listBoxEducations.Items.Clear();
            foreach (var education in educations)
            {
                listBoxEducations.Items.Add(education.ToString());
            }

            previousJobs = employee.PreviousJobs;
            listBoxPreviousJobs.Items.Clear();
            foreach (var previousJob in previousJobs)
            {
                listBoxPreviousJobs.Items.Add(previousJob.ToString());
            }

            jobMovements = employee.JobMovements;
            listBoxJobMovements.Items.Clear();
            foreach (var jobMovement in jobMovements)
            {
                listBoxJobMovements.Items.Add(jobMovement.ToString());
            }

            disciplinaryActions = employee.DisciplinaryActions;
            listBoxDisciplinaryActions.Items.Clear();
            foreach (var disciplinaryAction in disciplinaryActions)
            {
                listBoxDisciplinaryActions.Items.Add(disciplinaryAction.ToString());
            }

            incentives = employee.Incentives;
            listBoxIncentives.Items.Clear();
            foreach (var incentive in incentives)
            {
                listBoxIncentives.Items.Add(incentive.ToString());
            }
        }

        private void listBoxEducations_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxEducations.SelectedIndex == -1) return;

            var selectedEducation = educations[listBoxEducations.SelectedIndex];
            var window = new EducationForm(selectedEducation);
            if (window.ShowDialog() == DialogResult.OK)
            {
                var updatedEducation = window.Education;
                educations[listBoxEducations.SelectedIndex] = updatedEducation;
                listBoxEducations.Items[listBoxEducations.SelectedIndex] = updatedEducation.ToString();
            }
        }

        private void listBoxPreviousJobs_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPreviousJobs.SelectedIndex == -1) return;

            var selectedPreviousJob = previousJobs[listBoxPreviousJobs.SelectedIndex];
            var window = new PreviousJobForm(selectedPreviousJob);
            if (window.ShowDialog() == DialogResult.OK)
            {
                var updatedPreviousJob = window.PreviousJob;
                previousJobs[listBoxPreviousJobs.SelectedIndex] = updatedPreviousJob;
                listBoxPreviousJobs.Items[listBoxPreviousJobs.SelectedIndex] = updatedPreviousJob.ToString();
            }
        }

        private void listBoxJobMovements_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxJobMovements.SelectedIndex == -1) return;

            var selectedJobMovement = jobMovements[listBoxJobMovements.SelectedIndex];
            var window = new JobMovementForm(selectedJobMovement);
            if (window.ShowDialog() == DialogResult.OK)
            {
                var updatedJobMovement = window.JobMovement;
                jobMovements[listBoxJobMovements.SelectedIndex] = updatedJobMovement;
                listBoxJobMovements.Items[listBoxJobMovements.SelectedIndex] = updatedJobMovement.ToString();
            }
        }

        private void listBoxDisciplinaryActions_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxDisciplinaryActions.SelectedIndex == -1) return;

            var selectedDisciplinaryAction = disciplinaryActions[listBoxDisciplinaryActions.SelectedIndex];
            var window = new DisciplinaryActionForm(selectedDisciplinaryAction);
            if (window.ShowDialog() == DialogResult.OK)
            {
                var updatedDisciplinaryAction = window.Measure;
                disciplinaryActions[listBoxDisciplinaryActions.SelectedIndex] = updatedDisciplinaryAction;
                listBoxDisciplinaryActions.Items[listBoxDisciplinaryActions.SelectedIndex] = updatedDisciplinaryAction.ToString();
            }
        }

        private void listBoxIncentives_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxIncentives.SelectedIndex == -1) return;

            var selectedIncentive = incentives[listBoxIncentives.SelectedIndex];
            var window = new IncentiveForm(selectedIncentive);
            if (window.ShowDialog() == DialogResult.OK)
            {
                var updatedIncentive = window.Measure;
                incentives[listBoxIncentives.SelectedIndex] = updatedIncentive;
                listBoxIncentives.Items[listBoxIncentives.SelectedIndex] = updatedIncentive.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!AreCurrentPanelFieldsFilled() || !ValidateCurrentPanelFields())
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля и проверьте корректность введенных данных перед сохранением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (currentEmployee != null)
            {
                // Редактирование существующего сотрудника
                currentEmployee = SaveEditedEmployee();
            }
            else
            {
                // Добавление нового сотрудника
                currentEmployee = CreateEmployee();
            }

            // Путь к файлу, где будут храниться все сотрудники
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employees.json");

            // Получаем список всех сотрудников (если это новый сотрудник, добавляем его в список)
            List<Employee> employees = LoadEmployeesFromFile(filePath);
            employees.Add(currentEmployee); // Добавляем текущего сотрудника в список

            // Сохраняем обновленный список сотрудников в файл
            SaveEmployeesListToFile(employees, filePath);

            DialogResult = DialogResult.OK;
            this.Close();
        }
        private List<Employee> LoadEmployeesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    // Чтение файла и десериализация в список сотрудников
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
            return new List<Employee>(); // Если файл не найден, возвращаем пустой список
        }
        private void SaveEmployeesListToFile(List<Employee> employees, string filePath)
        {
            try
            {
                // Преобразуем список сотрудников в строку JSON
                string json = JsonConvert.SerializeObject(employees, Formatting.Indented);

                // Записываем строку JSON в файл
                File.WriteAllText(filePath, json);

                MessageBox.Show("Данные успешно сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }


        public Employee SaveEditedEmployee()
        {
            return new Employee(
                currentEmployee.PhotoPath,
                textBoxSurname.Text,
                textBoxName.Text,
                textBoxPatronymic.Text,
                textBoxPhoneNumber.Text,
                textBoxPassportNumber.Text,
                pickerDateOfBirth.Value,
                textBoxPlaceOfBirth.Text,
                textBoxHomeAddress.Text,
                pickerDateOfIssue.Value,
                textBoxIssuedBy.Text,
                comboBoxGender.Text,
                textBoxDepartment.Text,
                textBoxPosition.Text,
                pickerEmploymentStartDate.Value,
                comboBoxAcademicDegree.Text,
                comboBoxAcademicTitle.Text,
                incentives,
                disciplinaryActions,
                previousJobs,
                educations,
                jobMovements
            );
        }
    }
}
