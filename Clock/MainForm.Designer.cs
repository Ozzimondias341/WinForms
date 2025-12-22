namespace Clock
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.cbShowWeekday = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вклЭлемУправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьДатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьДеньНеделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поверхОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTime.Location = new System.Drawing.Point(19, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(224, 42);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "CurrentTime";
            this.labelTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseClick);
            this.labelTime.MouseHover += new System.EventHandler(this.labelTime_MouseHover);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowDate.Location = new System.Drawing.Point(26, 206);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(176, 29);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Показать дату";
            this.cbShowDate.UseVisualStyleBackColor = true;
            // 
            // cbShowWeekday
            // 
            this.cbShowWeekday.AutoSize = true;
            this.cbShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowWeekday.Location = new System.Drawing.Point(26, 241);
            this.cbShowWeekday.Name = "cbShowWeekday";
            this.cbShowWeekday.Size = new System.Drawing.Size(256, 29);
            this.cbShowWeekday.TabIndex = 2;
            this.cbShowWeekday.Text = "Показать день недели";
            this.cbShowWeekday.UseVisualStyleBackColor = true;
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(26, 276);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(252, 70);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Скрыть элементы управления";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "System tray";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem,
            this.тестToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вклЭлемУправленияToolStripMenuItem,
            this.показатьДатуToolStripMenuItem,
            this.показатьДеньНеделиToolStripMenuItem,
            this.поверхОконToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // вклЭлемУправленияToolStripMenuItem
            // 
            this.вклЭлемУправленияToolStripMenuItem.Name = "вклЭлемУправленияToolStripMenuItem";
            this.вклЭлемУправленияToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.вклЭлемУправленияToolStripMenuItem.Text = "Вкл элем управления";
            this.вклЭлемУправленияToolStripMenuItem.Click += new System.EventHandler(this.вклЭлемУправленияToolStripMenuItem_Click);
            // 
            // показатьДатуToolStripMenuItem
            // 
            this.показатьДатуToolStripMenuItem.Name = "показатьДатуToolStripMenuItem";
            this.показатьДатуToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.показатьДатуToolStripMenuItem.Text = "Показать дату";
            this.показатьДатуToolStripMenuItem.Click += new System.EventHandler(this.показатьДатуToolStripMenuItem_Click_1);
            // 
            // показатьДеньНеделиToolStripMenuItem
            // 
            this.показатьДеньНеделиToolStripMenuItem.Name = "показатьДеньНеделиToolStripMenuItem";
            this.показатьДеньНеделиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.показатьДеньНеделиToolStripMenuItem.Text = "Показать день недели";
            this.показатьДеньНеделиToolStripMenuItem.Click += new System.EventHandler(this.показатьДеньНеделиToolStripMenuItem_Click_1);
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.тестToolStripMenuItem.Text = "Тест";
            // 
            // поверхОконToolStripMenuItem
            // 
            this.поверхОконToolStripMenuItem.Name = "поверхОконToolStripMenuItem";
            this.поверхОконToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.поверхОконToolStripMenuItem.Text = "Поверх окон";
            this.поверхОконToolStripMenuItem.Click += new System.EventHandler(this.поверхОконToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(297, 365);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowWeekday);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Clock PV_521";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.CheckBox cbShowWeekday;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вклЭлемУправленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьДатуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьДеньНеделиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поверхОконToolStripMenuItem;
    }
}

