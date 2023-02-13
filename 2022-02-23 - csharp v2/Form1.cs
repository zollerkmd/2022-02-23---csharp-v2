using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_02_23___csharp_v2
{
    public partial class Form1 : Form
    {
        public class Termek
        {
            public string nev, db, ar;
        }

        List<Termek> lista_termek = new List<Termek>();

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            string nev = tbNev.Text;
            string darab = tbDarab.Text;
            string ar = tbAr.Text;
            string sor = nev + "," + darab + "," + ar;
            listBox1.Items.Add(sor);
            tbNev.Text = "";
            tbDarab.Text = "";
            tbAr.Text = "";

            // Listába rakás
            Termek t1 = new Termek();
            t1.nev = nev;
            t1.db = darab;
            t1.ar = ar;
            lista_termek.Add(t1);
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            int kivalasztott = listBox1.SelectedIndex;
            if (kivalasztott == -1)
            {
                MessageBox.Show("Nem törölhető elem!");
            }
            else
            {
                listBox1.Items.RemoveAt(kivalasztott);
            }
        }

        private void btnKimasol_Click(object sender, EventArgs e)
        {
            int kivalasztott = listBox1.SelectedIndex;
            if (kivalasztott == -1)
            {
                MessageBox.Show("Nincs kijelölt elem!");
            }
            else
            {
                String[] adatsor = new String[3];
                adatsor = listBox1.SelectedItem.ToString().Split(',');
                tbNev.Text = adatsor[0];
                tbDarab.Text = adatsor[1];
                tbAr.Text = adatsor[2];
            }
        }

        private void btnAtmasol_Click(object sender, EventArgs e)
        {
            int kivalasztott = listBox1.SelectedIndex;
            if (kivalasztott == -1)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
            }
            else
            {
                string atvitelre = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(atvitelre);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbForint_Click(object sender, EventArgs e)
        {
            if (tbAr.Text == "")
            {
                MessageBox.Show("Nincs érték!");
            }
            else if (rbForint.Checked == true)
            {
                int ar2 = Convert.ToInt32(tbAr.Text);
                tbAtvalt.Text = Convert.ToString(ar2 * 350);
            }
            else if (rbEuro.Checked == true)
            {
                int ar3 = Convert.ToInt32(tbAtvalt.Text);
                tbAtvalt.Text = Convert.ToString(ar3 / 350);
                MessageBox.Show("Másik kijelölés!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void rbEuro_Click(object sender, EventArgs e)
        {
            double ar3 = Convert.ToDouble(tbAtvalt.Text);
            if (rbEuro.Checked == true)
            {
                tbAtvalt.Text = Convert.ToString(ar3 / 350);
                MessageBox.Show("Másik kijelölés!");
            }
        }

        private void btnFajlba_Click(object sender, EventArgs e)
        {
            StreamWriter kiir = new StreamWriter("fajlnev.txt");
            foreach (Termek t in lista_termek)
            {
                kiir.WriteLine(t.nev + "," + t.db + "," + t.ar);
            }
            kiir.Flush();
            kiir.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
