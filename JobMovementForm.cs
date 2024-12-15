using System;
using System.Windows.Forms;

namespace course_work
{
    public partial class JobMovementForm : Form
    {
        public JobMovement JobMovement { get; set; }

        public JobMovementForm(JobMovement jobMovement = null)
        {
            InitializeComponent();

            if (jobMovement != null)
            {
                textBoxJobMovementReason.Text = jobMovement.MovementReason;
                pickerJobMovementDate.Value = jobMovement.MovementDate;
                textBoxOrderNumber.Text = jobMovement.OrderNumber;
                JobMovement = jobMovement;
            }
            else
            {
                JobMovement = new JobMovement(); // Создаем новый объект JobMovement
            }

            buttonSaveJobMovement.Click += (s, e) =>
            {
                try
                {
                    if (!AreAllFieldsFilled())
                    {
                        throw new ArgumentException("Заполните все поля перед сохранением!");
                    }

                    ValidateAllFields();

                    JobMovement.MovementReason = textBoxJobMovementReason.Text;
                    JobMovement.MovementDate = pickerJobMovementDate.Value;
                    JobMovement.OrderNumber = textBoxOrderNumber.Text;

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
            return !string.IsNullOrWhiteSpace(textBoxJobMovementReason.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxOrderNumber.Text);
        }

        private void ValidateAllFields()
        {
            Validation.ValidateAlphabetOnly(textBoxJobMovementReason.Text, "Причина перемещения");
            Validation.ValidateNumberWithSymbols(textBoxOrderNumber.Text, "Номер приказа");
            Validation.ValidateDateNotInFuture(pickerJobMovementDate.Value, "Дата перемещения");
        }
    }
}
