namespace Clock
{
    partial class AlarmTriggerDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmTriggerDialog));
            this.btnPutOffUntilLater = new System.Windows.Forms.Button();
            this.btnAlarmOff = new System.Windows.Forms.Button();
            this.labelAlarmTrigger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPutOffUntilLater
            // 
            this.btnPutOffUntilLater.Location = new System.Drawing.Point(156, 107);
            this.btnPutOffUntilLater.Name = "btnPutOffUntilLater";
            this.btnPutOffUntilLater.Size = new System.Drawing.Size(115, 68);
            this.btnPutOffUntilLater.TabIndex = 0;
            this.btnPutOffUntilLater.Text = "Отложить";
            this.btnPutOffUntilLater.UseVisualStyleBackColor = true;
            // 
            // btnAlarmOff
            // 
            this.btnAlarmOff.Location = new System.Drawing.Point(12, 107);
            this.btnAlarmOff.Name = "btnAlarmOff";
            this.btnAlarmOff.Size = new System.Drawing.Size(115, 68);
            this.btnAlarmOff.TabIndex = 1;
            this.btnAlarmOff.Text = "Отключить";
            this.btnAlarmOff.UseVisualStyleBackColor = true;
            // 
            // labelAlarmTrigger
            // 
            this.labelAlarmTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlarmTrigger.Location = new System.Drawing.Point(12, 9);
            this.labelAlarmTrigger.Name = "labelAlarmTrigger";
            this.labelAlarmTrigger.Size = new System.Drawing.Size(259, 95);
            this.labelAlarmTrigger.TabIndex = 2;
            this.labelAlarmTrigger.Text = "00:00";
            this.labelAlarmTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlarmTriggerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 208);
            this.Controls.Add(this.labelAlarmTrigger);
            this.Controls.Add(this.btnAlarmOff);
            this.Controls.Add(this.btnPutOffUntilLater);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlarmTriggerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Trigger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPutOffUntilLater;
        private System.Windows.Forms.Button btnAlarmOff;
        private System.Windows.Forms.Label labelAlarmTrigger;
    }
}