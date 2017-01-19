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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        List<Pracownik> ListaPracowników = new List<Pracownik>();

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pracownik abc = new Pracownik(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            ListaPracowników.Add(abc);
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lines = " ";
            string dir = @"C:\Users\wwinnic1\Documents\test.txt";

            foreach (var Pracownik in ListaPracowników)
            {
                lines += $"{Pracownik.imie} {Pracownik.nazwisko} {Pracownik.ID} {Pracownik.LDL}";
            }

            using (StreamWriter sw1 = new StreamWriter(dir))
            {
                sw1.WriteLine(lines);
                sw1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Users\wwinnic1\Documents\test.txt";

            using (StreamReader plik = new StreamReader(dir))
            {
                string line = plik.ReadToEnd();
                MessageBox.Show(line + "\n");
                plik.Close();
            }
        }
    }
}

// 