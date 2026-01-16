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
    public partial class AlarmDialog : Form
    {
        OpenFileDialog fileDialog;
        public Alarm Alarm { get; private set; }
        public AlarmDialog()
        {
            InitializeComponent();
            dtpDate.Enabled = false;
            fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Audio files (*.mp3;*.wav;*.wma;*.aac;*.flac;*.m4a;*.ogg)|*.mp3;*.wav;*.wma;*.aac;*.flac;*.m4a;*.ogg|All Files (*.*)|*.*";
            Alarm = new Alarm();
        }
        public AlarmDialog(Alarm alarm): this()
        {
            Alarm = alarm;
            Extract();
        }

        void Extract()
        {
            if (Alarm.Date != DateTime.MaxValue)
            {
                dtpDate.Value = Alarm.Date;
                checkBoxUseDate.Checked = true;
            }
            dtpTime.Value = DateTime.Now.Date + Alarm.Time;
            labelFilename.Text = Alarm.Filename;
            Alarm.Days.Extract(clbWeekdays);
        }


        private void checkBoxUseDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.Enabled = (sender as CheckBox).Checked;
            clbWeekdays.Enabled = !dtpDate.Enabled;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                labelFilename.Text = $"Filename: {fileDialog.FileName}";
            }
        }

        private void clbWeekdays_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("clbWeekdays_SelectedIndexChanged");

            for (int i = 0; i < clbWeekdays.CheckedItems.Count; i++)
            {
                Console.Write($"{clbWeekdays.CheckedItems[i]}\t");
            }
                Console.WriteLine();

            byte days = 0;

            for(int i = 0; i <clbWeekdays.CheckedIndices.Count;i++)
            {
                days |= (byte)(1 << clbWeekdays.CheckedIndices[i]);
                Console.Write($"{clbWeekdays.CheckedIndices[i]}\t");
            }
            Console.WriteLine() ;
            Console.WriteLine($"Days mask: {days}");
            Console.WriteLine("\n-------------------------------------------------------------------\n");
        }
        byte GetDaysMask()
        {
            byte days = 0;

            for (int i = 0; i < clbWeekdays.CheckedIndices.Count; i++)
            {
                days |= (byte)(1 << clbWeekdays.CheckedIndices[i]);
            }
            return days;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Alarm.Date = checkBoxUseDate.Checked ? dtpDate.Value : DateTime.MaxValue;
            Alarm.Time = dtpTime.Value.TimeOfDay;
            Alarm.Days = new Week(checkBoxUseDate.Checked ? (byte)0 : GetDaysMask());
            Alarm.Filename = labelFilename.Text;
        }
    }
}
