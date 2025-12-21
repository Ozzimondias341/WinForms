using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            Rectangle wa = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point((wa.Right - this.Width + 8), 0);
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
                //На русском
                labelTime.Text += $"\n{DateTime.Now.ToString("dddd")}"; 

                //На английском
                //labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
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
        bool IsVisible()
        {
            if(!cbShowDate.Visible ||  !cbShowWeekday.Visible || !btnHideControls.Visible) return false;

            return true;
        }

        void Switch_CheckBox(CheckBox checkBox)
        {
            if (checkBox.Checked) checkBox.Checked = false;
            else checkBox.Checked = true;
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            SetVisibility(false);
        }

        private void labelTime_MouseHover(object sender, EventArgs e)
        {
            SetVisibility(true);
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(e.Location);
            }
        }

        private void вклЭлемУправToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVisibility(!IsVisible());
        }

        private void показатьДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Switch_CheckBox(cbShowDate);
        }

        private void показатьДеньНеделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Switch_CheckBox(cbShowWeekday);
        }
    }
}
