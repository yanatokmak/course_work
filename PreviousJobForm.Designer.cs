namespace course_work
{
    partial class PreviousJobForm
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
            buttonSavePreviousJob = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxCompanyName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhoneNumber = new TextBox();
            label7 = new Label();
            pickerWorkingStartDate = new DateTimePicker();
            pickerWorkingEndDate = new DateTimePicker();
            textBoxLastJobTitle = new TextBox();
            textBoxDismissalReason = new TextBox();
            SuspendLayout();
            // 
            // buttonSavePreviousJob
            // 
            buttonSavePreviousJob.Location = new Point(424, 353);
            buttonSavePreviousJob.Name = "buttonSavePreviousJob";
            buttonSavePreviousJob.Size = new Size(75, 23);
            buttonSavePreviousJob.TabIndex = 0;
            buttonSavePreviousJob.Text = "Сохранить";
            buttonSavePreviousJob.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 1;
            label1.Text = "Название предпрятия:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Адрес:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Телефон:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(183, 15);
            label4.TabIndex = 4;
            label4.Text = "Начало трудовой деятельности:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 247);
            label5.Name = "label5";
            label5.Size = new Size(210, 15);
            label5.TabIndex = 5;
            label5.Text = "Кем работал на момент увольнения:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 290);
            label6.Name = "label6";
            label6.Size = new Size(128, 15);
            label6.TabIndex = 6;
            label6.Text = "Причина увольнения:";
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Location = new Point(241, 34);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(258, 23);
            textBoxCompanyName.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(241, 74);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(258, 23);
            textBoxAddress.TabIndex = 8;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(241, 115);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(167, 23);
            textBoxPhoneNumber.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 205);
            label7.Name = "label7";
            label7.Size = new Size(203, 15);
            label7.TabIndex = 10;
            label7.Text = "Окончание трудовой деятельности:";
            // 
            // pickerWorkingStartDate
            // 
            pickerWorkingStartDate.Location = new Point(241, 156);
            pickerWorkingStartDate.Name = "pickerWorkingStartDate";
            pickerWorkingStartDate.Size = new Size(167, 23);
            pickerWorkingStartDate.TabIndex = 11;
            // 
            // pickerWorkingEndDate
            // 
            pickerWorkingEndDate.Location = new Point(241, 197);
            pickerWorkingEndDate.Name = "pickerWorkingEndDate";
            pickerWorkingEndDate.Size = new Size(167, 23);
            pickerWorkingEndDate.TabIndex = 12;
            // 
            // textBoxLastJobTitle
            // 
            textBoxLastJobTitle.Location = new Point(241, 239);
            textBoxLastJobTitle.Name = "textBoxLastJobTitle";
            textBoxLastJobTitle.Size = new Size(258, 23);
            textBoxLastJobTitle.TabIndex = 13;
            // 
            // textBoxDismissalReason
            // 
            textBoxDismissalReason.Location = new Point(241, 282);
            textBoxDismissalReason.Name = "textBoxDismissalReason";
            textBoxDismissalReason.Size = new Size(258, 23);
            textBoxDismissalReason.TabIndex = 14;
            // 
            // PreviousJobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 388);
            Controls.Add(textBoxDismissalReason);
            Controls.Add(textBoxLastJobTitle);
            Controls.Add(pickerWorkingEndDate);
            Controls.Add(pickerWorkingStartDate);
            Controls.Add(label7);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxCompanyName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSavePreviousJob);
            Name = "PreviousJobForm";
            Text = "PreviousJobForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSavePreviousJob;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxCompanyName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNumber;
        private Label label7;
        private DateTimePicker pickerWorkingStartDate;
        private DateTimePicker pickerWorkingEndDate;
        private TextBox textBoxLastJobTitle;
        private TextBox textBoxDismissalReason;
    }
}