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

        private void btnMelodyChoise_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show(openFileDialog.FileName.ToString());
        }

        private void alarmDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (alarmDatePicker.Value < DateTime.Now)
            {
                MessageBox.Show("Невозможно выбрать прошедшую дату");
                alarmDatePicker.Value = DateTime.Now;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            string melodyPath = openFileDialog.FileName.ToString();
            AlarmMode alarmMode = new AlarmMode();
            DayOfWeek[] daysOfWeek = new DayOfWeek[7];
            DateTime dateTime = DateTime.Now;

            switch(cbMode.SelectedIndex)
            {
                case 0:
                    if (alarmWeekdaysChoise.CheckedItems.Count > 0)
                    {
                        for (int i = 0; i < alarmWeekdaysChoise.CheckedItems.Count; i++)
                        {
                            switch (alarmWeekdaysChoise.CheckedItems[i])
                            {
                                case "Понедельник":
                                    daysOfWeek[i] = DayOfWeek.Monday;
                                    break;
                                case "Вторник":
                                    daysOfWeek[i] = DayOfWeek.Tuesday;
                                    break;
                                case "Среда":
                                    daysOfWeek[i] = DayOfWeek.Wednesday;
                                    break;
                                case "Четверг":
                                    daysOfWeek[i] = DayOfWeek.Thursday;
                                    break;
                                case "Пятница":
                                    daysOfWeek[i] = DayOfWeek.Friday;
                                    break;
                                case "Суббота":
                                    daysOfWeek[i] = DayOfWeek.Saturday;
                                    break;
                                case "Воскресенье":
                                    daysOfWeek[i] = DayOfWeek.Sunday;
                                    break;

                            }
                        }
                        alarmMode = AlarmMode.Weekdays;
                    }
                    else
                    {
                        alarmMode = AlarmMode.Everyday;
                    }
                    break;

                case 1:
                    dateTime = alarmDatePicker.Value;
                    break;
            }

            dateTime.Hour = Int32.Parse(label_Hours.Text); 
           
        }
    }
}
