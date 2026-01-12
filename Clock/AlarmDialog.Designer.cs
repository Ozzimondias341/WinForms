namespace Clock
{
    partial class AlarmDialog
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.checkBoxUseDate = new System.Windows.Forms.CheckBox();
            this.labelWeekdays = new System.Windows.Forms.Label();
            this.clbWeekdays = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm:ss";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(177, 48);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(159, 31);
            this.dtpTime.TabIndex = 1;
            // 
            // checkBoxUseDate
            // 
            this.checkBoxUseDate.AutoSize = true;
            this.checkBoxUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUseDate.Location = new System.Drawing.Point(13, 13);
            this.checkBoxUseDate.Name = "checkBoxUseDate";
            this.checkBoxUseDate.Size = new System.Drawing.Size(262, 29);
            this.checkBoxUseDate.TabIndex = 2;
            this.checkBoxUseDate.Text = "На определённую дату";
            this.checkBoxUseDate.UseVisualStyleBackColor = true;
            // 
            // labelWeekdays
            // 
            this.labelWeekdays.AutoSize = true;
            this.labelWeekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeekdays.Location = new System.Drawing.Point(13, 86);
            this.labelWeekdays.Name = "labelWeekdays";
            this.labelWeekdays.Size = new System.Drawing.Size(130, 25);
            this.labelWeekdays.TabIndex = 3;
            this.labelWeekdays.Text = "Дни недели";
            // 
            // clbWeekdays
            // 
            this.clbWeekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbWeekdays.FormattingEnabled = true;
            this.clbWeekdays.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
            this.clbWeekdays.Location = new System.Drawing.Point(13, 115);
            this.clbWeekdays.Name = "clbWeekdays";
            this.clbWeekdays.Size = new System.Drawing.Size(120, 123);
            this.clbWeekdays.TabIndex = 4;
            // 
            // AlarmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 360);
            this.Controls.Add(this.clbWeekdays);
            this.Controls.Add(this.labelWeekdays);
            this.Controls.Add(this.checkBoxUseDate);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AlarmDialog";
            this.Text = "AlarmDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.CheckBox checkBoxUseDate;
        private System.Windows.Forms.Label labelWeekdays;
        private System.Windows.Forms.CheckedListBox clbWeekdays;
    }
}