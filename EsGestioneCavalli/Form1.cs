using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsGestioneCavalli
{
    public partial class Form1 : Form
    {
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
            string nome = txtNome.Text;
            string razza = txtRazza.Text;
            int anno;
            int.TryParse(txtAnno.Text , out anno);
            if(rdbMaschio.Checked)
            {
                string sesso = "M" ;
            }
            else 
            if()
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
