using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Clock
{
    public partial class AlarmCreate : Form
    {
        public AlarmCreate()
        {
            InitializeComponent();
            cbMode.SelectedIndex = 0;

            for (int i = 0; i < 24; i++)
            {  
                cbHoursChoise.Items.Add(i < 10 ? $"0{i.ToString()}" : i.ToString());
            }
            for (int i = 0; i < 60; i++)
            {
                cbMinutesChoise.Items.Add(i < 10 ? $"0{i.ToString()}" : i.ToString());
            }
            cbHoursChoise.SelectedIndex = 0;
            cbMinutesChoise.SelectedIndex = 0;
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMode.SelectedIndex)
            {
                case 0:
                    alarmDatePicker.Visible = false;
                    alarmWeekdaysChoise.Visible = true;
                    break;

                case 1:
                    alarmDatePicker.Visible = true;
                    alarmWeekdaysChoise.Visible = false;
                    break;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHoursChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Hours.Text = cbHoursChoise.Items[cbHoursChoise.SelectedIndex].ToString();
        }

        private void cbMinutesChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Minutes.Text = cbMinutesChoise.Items[cbMinutesChoise.SelectedIndex].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show(openFileDialog.FileName.ToString());
        }
    }
}
