using System;
using System.Windows.Forms;

namespace course_work
{
    public partial class DisciplinaryActionForm : Form
    {
        public Measure Measure { get; set; }

        public DisciplinaryActionForm(Measure measure = null)
        {
            InitializeComponent();

            if (measure != null)
            {
                comboBoxTypeDisciplinaryAction.Text = measure.Type?.ToString();
                textBoxDisciplinaryActionOrderNumber.Text = measure.OrderNumber;
                pickerDisciplinaryAction.Value = measure.Date;
                Measure = measure;
            }
            else
            {
                Measure = new Measure();
            }

            buttonSaveDisciplinaryAction.Click += (s, e) =>
            {
                try
                {
                    if (!AreAllFieldsFilled())
                    {
                        throw new ArgumentException("Заполните все поля перед сохранением!");
                    }

                    ValidateAllFields();

                    Measure.Type = comboBoxTypeDisciplinaryAction.Text;
                    Measure.OrderNumber = textBoxDisciplinaryActionOrderNumber.Text;
                    Measure.Date = pickerDisciplinaryAction.Value;

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
            return !string.IsNullOrWhiteSpace(comboBoxTypeDisciplinaryAction.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxDisciplinaryActionOrderNumber.Text);
        }

        private void ValidateAllFields()
        {
            Validation.ValidateNumberWithSymbols(textBoxDisciplinaryActionOrderNumber.Text, "Номер приказа");
            Validation.ValidateDateNotInFuture(pickerDisciplinaryAction.Value, "Дата взыскания");
        }
    }
}
