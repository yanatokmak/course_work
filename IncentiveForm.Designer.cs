namespace course_work
{
    partial class IncentiveForm
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
            buttonSaveIncentive = new Button();
            textBoxIncentiveType = new TextBox();
            pickerIncentiveDate = new DateTimePicker();
            textBoxIncentiveOrderNumber = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 61);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Вид поощрения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 109);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Дата:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 162);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Номер приказа:";
            // 
            // buttonSaveIncentive
            // 
            buttonSaveIncentive.Location = new Point(287, 288);
            buttonSaveIncentive.Name = "buttonSaveIncentive";
            buttonSaveIncentive.Size = new Size(75, 23);
            buttonSaveIncentive.TabIndex = 3;
            buttonSaveIncentive.Text = "Сохранить";
            buttonSaveIncentive.UseVisualStyleBackColor = true;
            // 
            // textBoxIncentiveType
            // 
            textBoxIncentiveType.Location = new Point(162, 58);
            textBoxIncentiveType.Name = "textBoxIncentiveType";
            textBoxIncentiveType.Size = new Size(200, 23);
            textBoxIncentiveType.TabIndex = 4;
            // 
            // pickerIncentiveDate
            // 
            pickerIncentiveDate.Location = new Point(162, 101);
            pickerIncentiveDate.Name = "pickerIncentiveDate";
            pickerIncentiveDate.Size = new Size(200, 23);
            pickerIncentiveDate.TabIndex = 5;
            // 
            // textBoxIncentiveOrderNumber
            // 
            textBoxIncentiveOrderNumber.Location = new Point(162, 154);
            textBoxIncentiveOrderNumber.Name = "textBoxIncentiveOrderNumber";
            textBoxIncentiveOrderNumber.Size = new Size(200, 23);
            textBoxIncentiveOrderNumber.TabIndex = 6;
            // 
            // IncentiveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 323);
            Controls.Add(textBoxIncentiveOrderNumber);
            Controls.Add(pickerIncentiveDate);
            Controls.Add(textBoxIncentiveType);
            Controls.Add(buttonSaveIncentive);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IncentiveForm";
            Text = "IncentiveForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSaveIncentive;
        private TextBox textBoxIncentiveType;
        private DateTimePicker pickerIncentiveDate;
        private TextBox textBoxIncentiveOrderNumber;
    }
}