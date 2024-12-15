namespace course_work
{
    partial class EducationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxEducation = new TextBox();
            textBoxGraduatedInstitution = new TextBox();
            numericUpDownGraduateYear = new NumericUpDown();
            textBoxSpeciality = new TextBox();
            textBoxEducationDocumentData = new TextBox();
            buttonSaveEducation = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGraduateYear).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 46);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Образование:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 104);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 1;
            label2.Text = "Оконченное учебное заведение:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 162);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Год окончания:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 215);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "Специальность:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 269);
            label5.Name = "label5";
            label5.Size = new Size(206, 15);
            label5.TabIndex = 4;
            label5.Text = "Данные документа об образовании:";
            // 
            // textBoxEducation
            // 
            textBoxEducation.Location = new Point(228, 38);
            textBoxEducation.Name = "textBoxEducation";
            textBoxEducation.Size = new Size(218, 23);
            textBoxEducation.TabIndex = 5;
            // 
            // textBoxGraduatedInstitution
            // 
            textBoxGraduatedInstitution.Location = new Point(228, 96);
            textBoxGraduatedInstitution.Name = "textBoxGraduatedInstitution";
            textBoxGraduatedInstitution.Size = new Size(218, 23);
            textBoxGraduatedInstitution.TabIndex = 6;
            // 
            // numericUpDownGraduateYear
            // 
            numericUpDownGraduateYear.Location = new Point(228, 154);
            numericUpDownGraduateYear.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericUpDownGraduateYear.Minimum = new decimal(new int[] { 1960, 0, 0, 0 });
            numericUpDownGraduateYear.Name = "numericUpDownGraduateYear";
            numericUpDownGraduateYear.Size = new Size(120, 23);
            numericUpDownGraduateYear.TabIndex = 7;
            numericUpDownGraduateYear.TextAlign = HorizontalAlignment.Center;
            numericUpDownGraduateYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // textBoxSpeciality
            // 
            textBoxSpeciality.Location = new Point(228, 207);
            textBoxSpeciality.Name = "textBoxSpeciality";
            textBoxSpeciality.Size = new Size(218, 23);
            textBoxSpeciality.TabIndex = 8;
            // 
            // textBoxEducationDocumentData
            // 
            textBoxEducationDocumentData.Location = new Point(228, 261);
            textBoxEducationDocumentData.Name = "textBoxEducationDocumentData";
            textBoxEducationDocumentData.Size = new Size(218, 23);
            textBoxEducationDocumentData.TabIndex = 9;
            // 
            // buttonSaveEducation
            // 
            buttonSaveEducation.Location = new Point(371, 320);
            buttonSaveEducation.Name = "buttonSaveEducation";
            buttonSaveEducation.Size = new Size(75, 23);
            buttonSaveEducation.TabIndex = 10;
            buttonSaveEducation.Text = "Сохранить";
            buttonSaveEducation.UseVisualStyleBackColor = true;
            // 
            // EducationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 355);
            Controls.Add(buttonSaveEducation);
            Controls.Add(textBoxEducationDocumentData);
            Controls.Add(textBoxSpeciality);
            Controls.Add(numericUpDownGraduateYear);
            Controls.Add(textBoxGraduatedInstitution);
            Controls.Add(textBoxEducation);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EducationForm";
            Text = "EducationForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownGraduateYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxEducation;
        private TextBox textBoxGraduatedInstitution;
        private NumericUpDown numericUpDownGraduateYear;
        private TextBox textBoxSpeciality;
        private TextBox textBoxEducationDocumentData;
        private Button buttonSaveEducation;
    }
}