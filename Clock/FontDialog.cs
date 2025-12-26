using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Clock
{
    public partial class FontDialog : Form
    {
            public Font Font { get; set; }
        int lastChosenIndex;
        int lastChosenWidth;
        public FontDialog()
        {
            InitializeComponent();
            LoadFonts("*.ttf");
            LoadFonts("*.otf");
            lastChosenIndex = 0;
            lastChosenWidth = 22;
            comboBoxFont.SelectedIndex = 1;
        }

        private void FontDialog_Load(object sender, EventArgs e)
        {
            numericUpDownFontSize.Value = (decimal)Font.Size;
        }

        void LoadFonts(string extention)
        {
            string currentDir = Application.ExecutablePath;
            Directory.SetCurrentDirectory($"{currentDir}\\..\\..\\..\\Fonts");
            
            //MessageBox.Show
            //    (
            //    this,
            //    //currentDir, 
            //    Directory.GetCurrentDirectory(),
            //    "CurrentDirectory",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information
            //    );

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), extention);
            //comboBoxFont.Items.AddRange(files); //Добавляет содержимое массива в comboBox
            for (int i = 0; i < files.Length; i++)
            {
                comboBoxFont.Items.Add( files[i].Split('\\').Last());
            }

        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string info = $"Selected:\nIndex\t{comboBoxFont.SelectedItem.ToString()}";
            //info += $"\nItem:\t{comboBoxFont.SelectedItem}";
            //info += $"\nText:\t{comboBoxFont.SelectedText}";
            //info += $"\nValue:\t{comboBoxFont.SelectedValue}";
            //MessageBox.Show(this, info, "SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            SetFont();
        }

        void SetFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(comboBoxFont.SelectedItem.ToString());
            labelExample.Font = new Font(pfc.Families[0], (float) numericUpDownFontSize.Value);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Font = labelExample.Font;
            this.lastChosenIndex = comboBoxFont.SelectedIndex;

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            labelExample.Font = this.Font;
            comboBoxFont.SelectedIndex = lastChosenIndex;
        }

        private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            SetFont();
        }
    }
}
