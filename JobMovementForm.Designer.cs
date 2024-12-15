namespace course_work
{
    partial class JobMovementForm
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
            buttonSaveJobMovement = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxJobMovementReason = new TextBox();
            pickerJobMovementDate = new DateTimePicker();
            textBoxOrderNumber = new TextBox();
            SuspendLayout();
            // 
            // buttonSaveJobMovement
            // 
            buttonSaveJobMovement.Location = new Point(319, 269);
            buttonSaveJobMovement.Name = "buttonSaveJobMovement";
            buttonSaveJobMovement.Size = new Size(75, 23);
            buttonSaveJobMovement.TabIndex = 0;
            buttonSaveJobMovement.Text = "Сохранить";
            buttonSaveJobMovement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 60);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 1;
            label1.Text = "Причина перемещения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 117);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Дата перемещения:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 170);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 3;
            label3.Text = "Номер приказа:";
            // 
            // textBoxJobMovementReason
            // 
            textBoxJobMovementReason.Location = new Point(192, 52);
            textBoxJobMovementReason.Name = "textBoxJobMovementReason";
            textBoxJobMovementReason.Size = new Size(202, 23);
            textBoxJobMovementReason.TabIndex = 4;
            // 
            // pickerJobMovementDate
            // 
            pickerJobMovementDate.Location = new Point(194, 109);
            pickerJobMovementDate.Name = "pickerJobMovementDate";
            pickerJobMovementDate.Size = new Size(137, 23);
            pickerJobMovementDate.TabIndex = 5;
            // 
            // textBoxOrderNumber
            // 
            textBoxOrderNumber.Location = new Point(192, 162);
            textBoxOrderNumber.Name = "textBoxOrderNumber";
            textBoxOrderNumber.Size = new Size(202, 23);
            textBoxOrderNumber.TabIndex = 6;
            // 
            // JobMovementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 304);
            Controls.Add(textBoxOrderNumber);
            Controls.Add(pickerJobMovementDate);
            Controls.Add(textBoxJobMovementReason);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSaveJobMovement);
            Name = "JobMovementForm";
            Text = "JobMovementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveJobMovement;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxJobMovementReason;
        private DateTimePicker pickerJobMovementDate;
        private TextBox textBoxOrderNumber;
    }
}