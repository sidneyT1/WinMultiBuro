using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MB_METIER;
using MB_DONNEES;




namespace MB_PRESENTATION
{
    public partial class Multiburo : Form
    {
        public Multiburo()
        {
            InitializeComponent();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LibBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TarBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            NumBox.Clear();
            LibBox.Clear();
            TarBox.Clear();
            CapNum.Value = 0;
            BUradio.Checked = false;
            OSradio.Checked = false;
            SRradio.Checked = false;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
           
            string numero = NumBox.Text;
            string libelle = LibBox.Text;
            int capacite = (int)CapNum.Value;
            string type = ""; 
            double tarif = Convert.ToDouble(TarBox.Text); 

            
            if (BUradio.Checked)
            {
                type = "BI";
            }
            else if (OSradio.Checked)
            {
                type = "OS";
            }
            else if (SRradio.Checked)
            {
                type = "SR";
            }

            
            Ressource R = new Ressource(numero, libelle, type, capacite, tarif);

            try
            {
                
                RessourceDAO.InsertRessource(R);
                MessageBox.Show("Ressource insérée avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion de la ressource : " + ex.Message);
            }
        }

        private void CapNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BUradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OSradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SRradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NumBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
