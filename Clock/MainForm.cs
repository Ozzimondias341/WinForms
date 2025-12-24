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

            foregroundColorDialog = new ColorDialog();
            backgroundColorDialog = new ColorDialog();
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
            foregroundColorDialog.ShowDialog();
            labelTime.ForeColor = foregroundColorDialog.Color;
        }

        private void tsmiBackgroundColor_Click(object sender, EventArgs e)
        {
            backgroundColorDialog.ShowDialog();
            labelTime.BackColor = backgroundColorDialog.Color;
        }
    }
}
