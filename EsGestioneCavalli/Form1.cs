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
        private void Form1_Load(object sender, EventArgs e)
        {

            CaricaDaFile();
        }
        private void CaricaDaFile()
        {
            if (File.Exists("cavalli.txt"))
            {
                string[] righe = File.ReadAllLines("cavalli.txt");

                foreach (string riga in righe)
                {
                    if (!string.IsNullOrWhiteSpace(riga) && nCavalli < 10)   // Verifica che la riga non sia vuota e che il maneggio non sia pieno
                    {
                        string[] campi = riga.Split(';');    //Divide la riga in campi usando il punto e virgola come separatore

                        if (campi.Length == 4)   // Verifica che ci siano esattamente 4 campi (nome, razza, anno, sesso)
                        {
                            string nome = campi[0];   //Assegna ogni campo alla variabile corrispondente
                            string razza = campi[1];
                            int anno;
                            int.TryParse(campi[2], out anno);
                            string sesso = campi[3];

                            maneggio[nCavalli] = new Cavallo(nome, razza, anno, sesso);
                            nCavalli++;

                            lstCavalli.Items.Add(riga);
                            fileesterno.Add(riga);
                        }
                    }
                }
            }
        }
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (nCavalli >= 10)
            {
                MessageBox.Show("Non è possibile aggiungere altri cavalli, maneggio pieno");
                return;
            }
             
                string nome = txtNome.Text.Trim();
                string razza = txtRazza.Text.Trim();
                int anno;
                int.TryParse(txtAnno.Text, out anno);
                string sesso = "";
                if (rdbMaschio.Checked)
                {
                    sesso = "M";
                }
                else if (rdbFemmina.Checked)
                {
                    sesso = "F";
                }
                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(razza) || anno <  1980 || anno > DateTime.Now.Year ||string.IsNullOrEmpty(sesso))
                {
                    MessageBox.Show("Inserire tutti i dati correttamente");
                    return;
                }
                else
                {
                    Cavallo c = new Cavallo(nome, razza, anno, sesso);
                    maneggio[nCavalli] = c;
                    nCavalli++;

                lstCavalli.Items.Add(c.nome + ";" + c.razza + ";" + c.anno + ";" + c.sesso);
                    fileesterno.Add(c.nome + ";" + c.razza + ";" + c.anno + ";" + c.sesso);
                    File.WriteAllLines("cavalli.txt", fileesterno);
                PulisciCampi();
                }

            }
        private void btnCerca_Click(object sender, EventArgs e)
        {
            string ncercato = txtNome.Text.Trim();

            if (string.IsNullOrEmpty(ncercato))
            {
                MessageBox.Show("Inserire il nome del cavallo da cercare");
                return;
            }

            for (int i = 0; i < nCavalli; i++)
            {
                if (maneggio[i].nome.ToLower() == ncercato.ToLower())
                {
                    lstCavalli.SelectedIndex = i;
                    MessageBox.Show("Cavallo trovato.\n" +
                        "Nome: " + maneggio[i].nome + "\n" +
                        "Razza: " + maneggio[i].razza + "\n" +
                        "Anno: " + maneggio[i].anno + "\n" +
                        "Sesso: " + maneggio[i].sesso);
                    return;
                }
            }

            MessageBox.Show("Cavallo non trovato");
        }
        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lstCavalli.SelectedIndex < 0)
            {
                MessageBox.Show("Selezionare un cavallo dalla lista");
                return;
            }

            int indice = lstCavalli.SelectedIndex;

            string nome = txtNome.Text.Trim();
            string razza = txtRazza.Text.Trim();
            int anno;
            int.TryParse(txtAnno.Text, out anno);

            string sesso = "";
            if (rdbMaschio.Checked)
                sesso = "M";
            else if (rdbFemmina.Checked)
                sesso = "F";

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(razza) || anno < 1980 || anno > DateTime.Now.Year || string.IsNullOrEmpty(sesso))
            {
                MessageBox.Show("Inserire tutti i dati correttamente");
                return;
            }

            maneggio[indice] = new Cavallo(nome, razza, anno, sesso);

            fileesterno[indice] = nome + ";" + razza + ";" + anno + ";" + sesso;
            lstCavalli.Items[indice] = nome + ";" + razza + ";" + anno + ";" + sesso;
            File.WriteAllLines("cavalli.txt", fileesterno);

            PulisciCampi();
            MessageBox.Show("Cavallo modificato");
        }
        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            if (lstCavalli.SelectedIndex < 0)
            {
                MessageBox.Show("Selezionare un cavallo dalla lista");
                return;
            }

            int indice = lstCavalli.SelectedIndex;

            // Sposta tutti i cavalli successivi indietro di una posizione
            for (int i = indice; i < nCavalli - 1; i++)
            {
                maneggio[i] = maneggio[i + 1];
            }

            nCavalli--;

            lstCavalli.Items.RemoveAt(indice);
            fileesterno.RemoveAt(indice);
            File.WriteAllLines("cavalli.txt", fileesterno);

            PulisciCampi();
            MessageBox.Show("Cavallo rimosso");
        }
        private void lstCavalli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCavalli.SelectedIndex >= 0)
            {
                int indice = lstCavalli.SelectedIndex;

                txtNome.Text = maneggio[indice].nome;
                txtRazza.Text = maneggio[indice].razza;
                txtAnno.Text = maneggio[indice].anno.ToString();

                if (maneggio[indice].sesso == "M")
                    rdbMaschio.Checked = true;
                else
                    rdbFemmina.Checked = true;
            }
        }
        private void PulisciCampi()
        {
            txtNome.Clear();
            txtRazza.Clear();
            txtAnno.Clear();
            rdbMaschio.Checked = false;
            rdbFemmina.Checked = false;
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

        

        private void rdbFemmina_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        

    }
}
