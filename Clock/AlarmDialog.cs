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
        public AlarmDialog()
        {
            InitializeComponent();
            dtpDate.Enabled = false;
            fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Audio files (*.mp3;*.wav;*.wma;*.aac;*.flac;*.m4a;*.ogg)|*.mp3;*.wav;*.wma;*.aac;*.flac;*.m4a;*.ogg|All Files (*.*)|*.*";
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
                labelFilename.Text = fileDialog.FileName;
            }
        }

        private void clbWeekdays_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show("Буба");
        }
    }
}
