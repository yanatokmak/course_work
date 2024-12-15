namespace course_work
{
    partial class DisciplinaryActionForm
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
            buttonSaveDisciplinaryAction = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxTypeDisciplinaryAction = new ComboBox();
            pickerDisciplinaryAction = new DateTimePicker();
            textBoxDisciplinaryActionOrderNumber = new TextBox();
            SuspendLayout();
            // 
            // buttonSaveDisciplinaryAction
            // 
            buttonSaveDisciplinaryAction.Location = new Point(258, 259);
            buttonSaveDisciplinaryAction.Name = "buttonSaveDisciplinaryAction";
            buttonSaveDisciplinaryAction.Size = new Size(75, 23);
            buttonSaveDisciplinaryAction.TabIndex = 0;
            buttonSaveDisciplinaryAction.Text = "Сохранить";
            buttonSaveDisciplinaryAction.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 75);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Вид взыскания:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 127);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Дата:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 174);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 3;
            label3.Text = "Номер приказа:";
            // 
            // comboBoxTypeDisciplinaryAction
            // 
            comboBoxTypeDisciplinaryAction.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeDisciplinaryAction.FormattingEnabled = true;
            comboBoxTypeDisciplinaryAction.Items.AddRange(new object[] { "Увольнение", "Замечание", "Выговор" });
            comboBoxTypeDisciplinaryAction.Location = new Point(146, 72);
            comboBoxTypeDisciplinaryAction.Name = "comboBoxTypeDisciplinaryAction";
            comboBoxTypeDisciplinaryAction.Size = new Size(158, 23);
            comboBoxTypeDisciplinaryAction.TabIndex = 4;
            // 
            // pickerDisciplinaryAction
            // 
            pickerDisciplinaryAction.Location = new Point(146, 121);
            pickerDisciplinaryAction.Name = "pickerDisciplinaryAction";
            pickerDisciplinaryAction.Size = new Size(158, 23);
            pickerDisciplinaryAction.TabIndex = 5;
            // 
            // textBoxDisciplinaryActionOrderNumber
            // 
            textBoxDisciplinaryActionOrderNumber.Location = new Point(147, 171);
            textBoxDisciplinaryActionOrderNumber.Name = "textBoxDisciplinaryActionOrderNumber";
            textBoxDisciplinaryActionOrderNumber.Size = new Size(157, 23);
            textBoxDisciplinaryActionOrderNumber.TabIndex = 6;
            // 
            // DisciplinaryActionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 294);
            Controls.Add(textBoxDisciplinaryActionOrderNumber);
            Controls.Add(pickerDisciplinaryAction);
            Controls.Add(comboBoxTypeDisciplinaryAction);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSaveDisciplinaryAction);
            Name = "DisciplinaryActionForm";
            Text = "DisciplinaryActionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveDisciplinaryAction;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxTypeDisciplinaryAction;
        private DateTimePicker pickerDisciplinaryAction;
        private TextBox textBoxDisciplinaryActionOrderNumber;
    }
}