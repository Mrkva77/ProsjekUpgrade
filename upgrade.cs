using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProsjekUgrade
{
    public partial class Form1 : Form
    {
        // TODO: overide to string
        List<Prosjek> listaOcjna = new List<Prosjek>();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //ovdje ide kod za učitavanje .csv datoteke
            
        }

        private void Btn_unesi_Click(object sender, EventArgs e)
        {
            // TODO: napraviti provjeru
            // try...catch
            // ocjena mora biti od 1 do 5
            // predmet nesmije biti prazan string
            
            Prosjek prosjek = new Prosjek(comboBox1.Text,
                Convert.ToInt32(textBox1));

            listaOcjna.Add(prosjek);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void Btn_ispisi_Click(object sender, EventArgs e)
        {
            foreach (Prosjek prosjek in listaOcjna)
            {
                textBox2.AppendText(prosjek.NazivPredmeta 
                    + "\t" + 
                    prosjek.Ocjena + "\r\n");
            }
        }
    }
}
