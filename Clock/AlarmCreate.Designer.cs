namespace Clock
{
    partial class AlarmCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmCreate));
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.alarmWeekdaysChoise = new System.Windows.Forms.CheckedListBox();
            this.alarmDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label_Hours = new System.Windows.Forms.Label();
            this.label_Colon = new System.Windows.Forms.Label();
            this.label_Minutes = new System.Windows.Forms.Label();
            this.cbHoursChoise = new System.Windows.Forms.ComboBox();
            this.cbMinutesChoise = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnMelodyChoise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Дни недели",
            "Число месяца"});
            this.cbMode.Location = new System.Drawing.Point(13, 13);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(120, 21);
            this.cbMode.TabIndex = 0;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // alarmWeekdaysChoise
            // 
            this.alarmWeekdaysChoise.FormattingEnabled = true;
            this.alarmWeekdaysChoise.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.alarmWeekdaysChoise.Location = new System.Drawing.Point(13, 41);
            this.alarmWeekdaysChoise.Name = "alarmWeekdaysChoise";
            this.alarmWeekdaysChoise.Size = new System.Drawing.Size(120, 109);
            this.alarmWeekdaysChoise.TabIndex = 1;
            // 
            // alarmDatePicker
            // 
            this.alarmDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.alarmDatePicker.Location = new System.Drawing.Point(13, 41);
            this.alarmDatePicker.Name = "alarmDatePicker";
            this.alarmDatePicker.Size = new System.Drawing.Size(120, 20);
            this.alarmDatePicker.TabIndex = 2;
            this.alarmDatePicker.ValueChanged += new System.EventHandler(this.alarmDatePicker_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(306, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(225, 162);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label_Hours
            // 
            this.label_Hours.AutoSize = true;
            this.label_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Hours.Location = new System.Drawing.Point(195, 64);
            this.label_Hours.Name = "label_Hours";
            this.label_Hours.Size = new System.Drawing.Size(70, 51);
            this.label_Hours.TabIndex = 5;
            this.label_Hours.Text = "00";
            // 
            // label_Colon
            // 
            this.label_Colon.AutoSize = true;
            this.label_Colon.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Colon.Location = new System.Drawing.Point(271, 63);
            this.label_Colon.Name = "label_Colon";
            this.label_Colon.Size = new System.Drawing.Size(34, 51);
            this.label_Colon.TabIndex = 6;
            this.label_Colon.Text = ":";
            // 
            // label_Minutes
            // 
            this.label_Minutes.AutoSize = true;
            this.label_Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Minutes.Location = new System.Drawing.Point(311, 64);
            this.label_Minutes.Name = "label_Minutes";
            this.label_Minutes.Size = new System.Drawing.Size(70, 51);
            this.label_Minutes.TabIndex = 7;
            this.label_Minutes.Text = "00";
            // 
            // cbHoursChoise
            // 
            this.cbHoursChoise.FormattingEnabled = true;
            this.cbHoursChoise.Location = new System.Drawing.Point(195, 40);
            this.cbHoursChoise.Name = "cbHoursChoise";
            this.cbHoursChoise.Size = new System.Drawing.Size(70, 21);
            this.cbHoursChoise.TabIndex = 8;
            this.cbHoursChoise.SelectedIndexChanged += new System.EventHandler(this.cbHoursChoise_SelectedIndexChanged);
            // 
            // cbMinutesChoise
            // 
            this.cbMinutesChoise.FormattingEnabled = true;
            this.cbMinutesChoise.Location = new System.Drawing.Point(312, 40);
            this.cbMinutesChoise.Name = "cbMinutesChoise";
            this.cbMinutesChoise.Size = new System.Drawing.Size(70, 21);
            this.cbMinutesChoise.TabIndex = 9;
            this.cbMinutesChoise.SelectedIndexChanged += new System.EventHandler(this.cbMinutesChoise_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "C:\\Users\\Максим\\Desktop\\Programming\\WPF\\WinForms\\Clock\\Melody\\Starset_-_My_Demons" +
    "_56774126.mp3";
            this.openFileDialog.Filter = "\"MP3 файлы (*.mp3)|*.mp3|Все файлы (*.*)|*.*\"";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // btnMelodyChoise
            // 
            this.btnMelodyChoise.Location = new System.Drawing.Point(12, 162);
            this.btnMelodyChoise.Name = "btnMelodyChoise";
            this.btnMelodyChoise.Size = new System.Drawing.Size(121, 23);
            this.btnMelodyChoise.TabIndex = 10;
            this.btnMelodyChoise.Text = "Выбор мелодии";
            this.btnMelodyChoise.UseVisualStyleBackColor = true;
            this.btnMelodyChoise.Click += new System.EventHandler(this.btnMelodyChoise_Click);
            // 
            // AlarmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 197);
            this.Controls.Add(this.btnMelodyChoise);
            this.Controls.Add(this.cbMinutesChoise);
            this.Controls.Add(this.cbHoursChoise);
            this.Controls.Add(this.label_Minutes);
            this.Controls.Add(this.label_Colon);
            this.Controls.Add(this.label_Hours);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.alarmDatePicker);
            this.Controls.Add(this.alarmWeekdaysChoise);
            this.Controls.Add(this.cbMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlarmCreate";
            this.Text = "AlarmCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.CheckedListBox alarmWeekdaysChoise;
        private System.Windows.Forms.DateTimePicker alarmDatePicker;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label_Hours;
        private System.Windows.Forms.Label label_Colon;
        private System.Windows.Forms.Label label_Minutes;
        private System.Windows.Forms.ComboBox cbHoursChoise;
        private System.Windows.Forms.ComboBox cbMinutesChoise;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnMelodyChoise;
    }
}