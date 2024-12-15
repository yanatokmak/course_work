using System;
using System.Windows.Forms;

namespace course_work
{
    public partial class PreviousJobForm : Form
    {
        public PreviousJob PreviousJob { get; set; }

        public PreviousJobForm(PreviousJob previousJob = null)
        {
            InitializeComponent();

            if (previousJob != null)
            {
                textBoxCompanyName.Text = previousJob.CompanyName;
                textBoxAddress.Text = previousJob.Address;
                textBoxPhoneNumber.Text = previousJob.PhoneNumber;
                textBoxLastJobTitle.Text = previousJob.LastJobTitle;
                textBoxDismissalReason.Text = previousJob.DismissalReason;
                pickerWorkingStartDate.Value = previousJob.WorkingStartDate;
                pickerWorkingEndDate.Value = previousJob.WorkingEndDate;
                PreviousJob = previousJob;
            }
            else
            {
                PreviousJob = new PreviousJob(); 
            }

            buttonSavePreviousJob.Click += (s, e) =>
            {
                try
                {
                    if (!AreAllFieldsFilled())
                    {
                        throw new ArgumentException("Заполните все поля перед сохранением!");
                    }

                    ValidateAllFields();

                    PreviousJob.CompanyName = textBoxCompanyName.Text;
                    PreviousJob.Address = textBoxAddress.Text;
                    PreviousJob.PhoneNumber = textBoxPhoneNumber.Text;
                    PreviousJob.LastJobTitle = textBoxLastJobTitle.Text;
                    PreviousJob.DismissalReason = textBoxDismissalReason.Text;
                    PreviousJob.WorkingStartDate = pickerWorkingStartDate.Value;
                    PreviousJob.WorkingEndDate = pickerWorkingEndDate.Value;

                    DialogResult = DialogResult.OK;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(textBoxCompanyName.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxAddress.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxLastJobTitle.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxDismissalReason.Text);
        }

        private void ValidateAllFields()
        {
            Validation.ValidateLength(textBoxPhoneNumber.Text, "Телефон", 3, 11);
            Validation.ValidateAlphabetOnly(textBoxLastJobTitle.Text, "Должность на момент увольнения");
            Validation.ValidateAlphabetOnly(textBoxDismissalReason.Text, "Причина увольнения");

            if (pickerWorkingStartDate.Value > pickerWorkingEndDate.Value)
            {
                throw new ArgumentException("Дата начала трудовой деятельности не может быть позднее даты окончания трудовой деятельности.");
            }

            Validation.ValidateDateNotInFuture(pickerWorkingStartDate.Value, "Дата начала работы");
            Validation.ValidateDateNotInFuture(pickerWorkingEndDate.Value, "Дата окончания работы");
        }
    }
}
