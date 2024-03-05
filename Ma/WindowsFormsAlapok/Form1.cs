using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlapok
{
    public partial class Form_teruletekatlaga : Form
    {
        public Form_teruletekatlaga()
        {
            InitializeComponent();
        }

        private void Button_Betoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "csv files (*.csv) |*.csv | txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "Adatfájl neve";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName)) 
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        ListBox_orszagok.Items.Add(new Orszag(sr.ReadLine()));
                    }
                }    
            }
        }
    }
}
