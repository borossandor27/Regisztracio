using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regisztracio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Regisztracio(object sender, EventArgs e)
        {
            listBox_Adatok.Items.Clear();
            listBox_Adatok.Items.Add("Név: " + textBox_Nev.Text);
            listBox_Adatok.Items.Add("Lakcím: " + textBox_Lakcim.Text);
            listBox_Adatok.Items.Add("Helység: " + comboBox_Helyseg.SelectedItem.ToString());
            if (radioButton_No.Checked)
            {
                listBox_Adatok.Items.Add("Neme: Nő");
            }
            if (radioButton_Ferfi.Checked)
            {
                listBox_Adatok.Items.Add("Neme: Férfi");
            }
            if (radioButton_egyeb.Checked)
            {
                listBox_Adatok.Items.Add("Neme: Egyéb");
            }
            if (checkBox_TV.Checked)
            {
                listBox_Adatok.Items.Add("hobby: TV nézés");
            }
            if (checkBox_Mobil.Checked)
            {
                listBox_Adatok.Items.Add("hobby: Mobil nyomkodás");
            }
            if (checkBox_Kerekpar.Checked)
            {
                listBox_Adatok.Items.Add("hobby: Kerékpározás");
            }
        }
    }
}
