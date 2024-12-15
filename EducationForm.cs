using System;
using System.Windows.Forms;

namespace course_work
{
    public partial class EducationForm : Form
    {
        public Education Education { get; set; }

        public EducationForm(Education education = null)
        {
            InitializeComponent();

            if (education != null)
            {
                textBoxEducation.Text = education.EducationLevel;
                textBoxGraduatedInstitution.Text = education.GraduatedInstitution;
                numericUpDownGraduateYear.Value = education.GraduationYear;
                textBoxSpeciality.Text = education.Speciality;
                textBoxEducationDocumentData.Text = education.EducationDocumentData;
                Education = education;
            }
            else
            {
                Education = new Education(); 
            }



            buttonSaveEducation.Click += (s, e) =>
            {
                try
                {
                    if (!AreAllFieldsFilled())
                    {
                        throw new ArgumentException("Заполните все поля перед сохранением!");
                    }

                    ValidateAllFields();

                    Education.EducationLevel = textBoxEducation.Text;
                    Education.GraduatedInstitution = textBoxGraduatedInstitution.Text;
                    Education.GraduationYear = (int)numericUpDownGraduateYear.Value;
                    Education.Speciality = textBoxSpeciality.Text;
                    Education.EducationDocumentData = textBoxEducationDocumentData.Text;

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
            return !string.IsNullOrWhiteSpace(textBoxEducation.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxGraduatedInstitution.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxSpeciality.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxEducationDocumentData.Text);
        }

        private void ValidateAllFields()
        {
            Validation.ValidateNoDigits(textBoxEducation.Text, "Уровень образования");
            Validation.ValidateAlphabetOnly(textBoxGraduatedInstitution.Text, "Оконченное учебное заведение");
            Validation.ValidateNumberWithSymbols(textBoxEducationDocumentData.Text, "Данные документа об образовании");
            Validation.ValidateAlphabetOnly(textBoxSpeciality.Text, "Специальность");
        }
    }
}
