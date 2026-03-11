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

namespace EsGestioneCavalli
{
    public partial class Form1 : Form
    {
        int nCavalli = 0;   
        Cavallo[] maneggio = new Cavallo[10];
        List<string> fileesterno = new List<string>();
        public struct Cavallo
        {
            public string nome;
            public string razza;
            public int anno;
            public string sesso;

            public Cavallo (string n, string r, int a,string s)
            {
                nome = n;
                razza = r;
                anno = a;
                sesso = s;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (nCavalli >= 10)
            {
                MessageBox.Show("Non è possibile aggiungere altri cavalli, maneggio pieno");
            }
            else { 
                string nome = txtNome.Text;
                string razza = txtRazza.Text;
                int anno;
                int.TryParse(txtAnno.Text, out anno);
                string sesso = " ";
                if (rdbMaschio.Checked)
                {
                    sesso = "M";
                }
                else if (rdbFemmina.Checked)
                {
                    sesso = "F";
                }
                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(razza) || anno <  1900 || anno > DateTime.Now.Year ||string.IsNullOrEmpty(sesso))
                {
                    MessageBox.Show("Inserire tutti i dati correttamente");
                    return;
                }
                else
                {
                    Cavallo c = new Cavallo(nome, razza, anno, sesso);
                    maneggio[nCavalli] = c;
                    lstCavalli.Items.Add(c.nome + " - " + c.razza + " - " + c.anno + " - " + c.sesso);
                    fileesterno.Add(c.nome + " - " + c.razza + " - " + c.anno + " - " + c.sesso);
                    File.WriteAllLines("cavalli.txt", fileesterno);
                }
            }
        }

        private void rdbMaschio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRazza_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnno_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbFemmina_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void btnModifica_Click(object sender, EventArgs e)
        {

        }

        private void btnCerca_Click(object sender, EventArgs e)
        {

        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {

        }

        private void lstCavalli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
