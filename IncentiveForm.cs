using System;
using System.Windows.Forms;

namespace course_work
{
    public partial class IncentiveForm : Form
    {
        public Measure Measure { get; set; }

        public IncentiveForm(Measure measure = null)
        {
            InitializeComponent();

            if (measure != null)
            {
                textBoxIncentiveType.Text = measure.Type?.ToString();
                textBoxIncentiveOrderNumber.Text = measure.OrderNumber;
                pickerIncentiveDate.Value = measure.Date;
                Measure = measure;
            }
            else
            {
                Measure = new Measure();
            }

            buttonSaveIncentive.Click += (s, e) =>
            {
                try
                {
                    if (!AreAllFieldsFilled())
                    {
                        throw new ArgumentException("Заполните все поля перед сохранением!");
                    }

                    ValidateAllFields();

                    Measure.Type = textBoxIncentiveType.Text;
                    Measure.OrderNumber = textBoxIncentiveOrderNumber.Text;
                    Measure.Date = pickerIncentiveDate.Value;

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
            return !string.IsNullOrWhiteSpace(textBoxIncentiveType.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxIncentiveOrderNumber.Text);
        }

        private void ValidateAllFields()
        {
            Validation.ValidateNumberWithSymbols(textBoxIncentiveOrderNumber.Text, "Номер приказа");
            Validation.ValidateDateNotInFuture(pickerIncentiveDate.Value, "Дата поощрения");
        }
    }
}
