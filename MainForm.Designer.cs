namespace course_work
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxEmployees = new ListBox();
            label1 = new Label();
            buttonDeleteEmployee = new Button();
            buttonEditEmployee = new Button();
            buttonAdd = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 15;
            listBoxEmployees.Location = new Point(63, 43);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(677, 334);
            listBoxEmployees.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 1;
            label1.Text = "Список сотрудников";
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Location = new Point(307, 395);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(75, 23);
            buttonDeleteEmployee.TabIndex = 2;
            buttonDeleteEmployee.Text = "Удалить";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonEditEmployee
            // 
            buttonEditEmployee.Location = new Point(179, 395);
            buttonEditEmployee.Name = "buttonEditEmployee";
            buttonEditEmployee.Size = new Size(97, 23);
            buttonEditEmployee.TabIndex = 3;
            buttonEditEmployee.Text = "Редактировать";
            buttonEditEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(63, 395);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(88, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(665, 395);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEditEmployee);
            Controls.Add(buttonDeleteEmployee);
            Controls.Add(label1);
            Controls.Add(listBoxEmployees);
            Name = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEmployees;
        private Label label1;
        private Button buttonDeleteEmployee;
        private Button buttonEditEmployee;
        private Button buttonAdd;
        private Button buttonSave;
    }
}
