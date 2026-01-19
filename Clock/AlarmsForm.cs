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
    public partial class AlarmsForm : Form
    {
        public ListBox List { get => listBoxAlarms; }
        public AlarmsForm()
        {
            InitializeComponent();
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AlarmDialog alarmDialog = new AlarmDialog();
            alarmDialog.Location = new Point
                (
                this.Location.X + this.Width / 4,
                this.Location.Y + this.Height / 6
                );
            if (alarmDialog.ShowDialog() == DialogResult.OK)
            {
                Alarm alarm = new Alarm(alarmDialog.Alarm);
                if (alarm.Days == new Week(0)) alarm.Days = new Week(127);
                listBoxAlarms.Items.Add(alarm);
            }
        }

        private void listBoxAlarms_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAlarms.Items.Count > 0 && listBoxAlarms.SelectedItem != null)
            {
                AlarmDialog alarm = new AlarmDialog(listBoxAlarms.SelectedItem as Alarm);
                alarm.ShowDialog();
                listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = new Alarm(alarm.Alarm);
            }
            else
            {
                buttonAdd_Click(sender, e);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxAlarms.Items.Count <= 0 && listBoxAlarms.SelectedItem == null) return;
            listBoxAlarms.Items.Remove(listBoxAlarms.SelectedIndex);
        }
    }
}
