using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Clock
{
    public partial class MainForm : Form
    {
        FontDialog fontDialog;
        ColorDialog foregroundColorDialog;
        ColorDialog backgroundColorDialog;

        public MainForm()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point
                (
                Screen.PrimaryScreen.Bounds.Width - this.Width,
                50
                );
            SetVisibility(false);

            this.TopMost = tsmiTopmost.Checked = true;

            foregroundColorDialog = new ColorDialog();
            backgroundColorDialog = new ColorDialog();
            fontDialog = new FontDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString
                (
                "HH:mm:ss"
                //System.Globalization.CultureInfo.InvariantCulture
                );

            if (cbShowDate.Checked)
            {
               
                labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
            }

            if (cbShowWeekday.Checked) 
            {
                labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
            }

            notifyIcon.Text = labelTime.Text;
        }

        void SetVisibility(bool visible)
        {
            cbShowDate.Visible = visible;
            cbShowWeekday.Visible = visible;
            btnHideControls.Visible = visible;
            this.ShowInTaskbar = visible;
            this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle : FormBorderStyle.None;
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            SetVisibility(tsmiShowControls.Checked = false);
        }

        //private void labelTime_MouseHover(object sender, EventArgs e)
        //{
        //    SetVisibility(true);
        //}

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (!TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
           
        }


        private void показатьДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tsmiTopmost_Click(object sender, EventArgs e) => this.TopMost = tsmiTopmost.Checked;
        

        private void tsmiShowControls_CheckedChanged(object sender, EventArgs e) => SetVisibility((sender as ToolStripMenuItem).Checked);
        

        private void tsmiShowDate_CheckedChanged(object sender, EventArgs e) =>
            cbShowDate.Checked = tsmiShowDate.Checked;

        private void cbShowDate_CheckedChanged(object sender, EventArgs e) =>
            cbShowDate.Checked = tsmiShowDate.Checked;



        private void tsmiShowWeekday_CheckedChanged(object sender, EventArgs e) =>
            cbShowWeekday.Checked = tsmiShowWeekday.Checked;

        private void cbShowWeekday_CheckedChanged(object sender, EventArgs e) =>
            cbShowWeekday.Checked = tsmiShowWeekday.Checked;

        private void tsmiQuit_Click(object sender, EventArgs e) => this.Close();

        private void tsmiForegroundColor_Click(object sender, EventArgs e)
        {
            DialogResult result = foregroundColorDialog.ShowDialog();
            if(result == DialogResult.OK) labelTime.ForeColor = foregroundColorDialog.Color;
        }

        private void tsmiBackgroundColor_Click(object sender, EventArgs e)
        {
            DialogResult result = backgroundColorDialog.ShowDialog();
            if (result == DialogResult.OK) labelTime.BackColor = backgroundColorDialog.Color;
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            fontDialog.Location = new Point
                (
                this.Location.X - fontDialog.Width - 10,
                this.Location.Y
                );
            fontDialog.Font = labelTime.Font;
            DialogResult result = fontDialog.ShowDialog();
            if( result == DialogResult.OK ) labelTime.Font = fontDialog.Font;
        }

        private void tsmiAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            string key_name = "ClockPV_521";
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true); //true - открыть ветку на запись
            if( tsmiAutoStart.Checked ) rk.SetValue(key_name, Application.ExecutablePath);
            else rk.DeleteValue(key_name, false); //false - не бросать исключение если данная запись отсутствует в реестре
            rk.Dispose();
        }
    }
}
