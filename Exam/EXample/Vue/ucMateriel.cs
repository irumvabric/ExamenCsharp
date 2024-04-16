using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Controlleur;
using Modele;
using System.IO;
using System.Net.Sockets;

namespace Vue
{
    public partial class ucMateriel : UserControl
    {
        Materiel mater1 = null;
        ArrayList listeClients  = new ArrayList();
        ArrayList listeMateriels  = new ArrayList();
        public ucMateriel()
        {
            InitializeComponent();
        //    listeClients = Factory.getAllClients(); 
        }

        private void ucMateriel_Load(object sender, EventArgs e)
        {
            ChargerClients();
        }

        void ChargerClients()
        {
            comboBoxClients.DataSource = listeClients;
            comboBoxClients.DisplayMember = "IdentificationComplete";
        }

        private void tbxIdmateriel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMarque_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbCommentaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptbMateriel_Click(object sender, EventArgs e)
        {

        }

        private void btnImporte_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choisir l'image(*.PNG;*.JPG;*GIF)|*.PNG;*.JPG;*GIF";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbMateriel.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
                string matri = tbxIdmateriel.Text;
            
            //    Factory.addMateriel(saisirMateriel());
                remplirLaTable();
                reset();

        }

        public Materiel saisirMateriel()
        {
            Materiel mater1 = new Materiel();

            mater1.Idmat = tbxIdmateriel.Text;
            mater1.Nom = tbxNom.Text;
            mater1.Marque = tbxMarque.Text;
            mater1.NumeroSerie = tbxSerie.Text;
            mater1.Commentaire = rtbCommentaire.Text;
            mater1.IdClient = comboBoxClients.Text;

            int indexClient = comboBoxClients.SelectedIndex;
            mater1.IdClient = ((Client)listeClients[indexClient]).Matricule;

            MemoryStream ms = new MemoryStream();
            if(ptbMateriel != null)
            {
                ptbMateriel.Image.Save(ms, ptbMateriel.Image.RawFormat);
                mater1.Photo = ms.ToArray();
            }
            return mater1;
        }

        void reset()
        {
            tbxIdmateriel.Text = "";
            tbxNom.Text = "";
            tbxMarque.Text = "";
            tbxSerie.Text = "";
            rtbCommentaire.Text = "";
            
            
            /* cbxNationalite.Text = techniciens.Nationalite;
            dateTimePickerDateEmbouche.MinDate = techniciens.DateEmbauche;
            dateTimePickerDateNaiss.MinDate = techniciens.DateNaiss; */
        }

        void recuperationMateriel(Materiel mater1)
        {
           tbxIdmateriel.Text = mater1.Idmat;
            tbxNom.Text = mater1.Nom;
            tbxMarque.Text = mater1.Marque;
            tbxSerie.Text = mater1.NumeroSerie;
            rtbCommentaire.Text = mater1.Commentaire;
            comboBoxClients.Text = mater1.IdClient;
          //  ptbMateriel = mater1.Photo;


            /* tbx
            cbxNationalite.Text = techniciens.Nationalite;
            dateTimePickerDateEmbouche.MinDate = techniciens.DateEmbauche;
            dateTimePickerDateNaiss.MinDate = techniciens.DateNaiss; */

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remplirLaTable();
        }

        void remplirLaTable()

        {
//listeMateriels = Factory.getAllMateriel();
            dataGridView1.DataSource = listeMateriels;
            dataGridView1.Columns["idMat"].DisplayIndex = 0;
            dataGridView1.Columns["nom"].DisplayIndex = 1;
        //    dataGridView1.Columns["serie"].DisplayIndex = 2;
            dataGridView1.Columns["Commentaire"].DisplayIndex = 4;
            dataGridView1.Columns["idClient"].DisplayIndex = 5;
            dataGridView1.Columns["photo"].DisplayIndex = 3;

            dataGridView1.Columns["idMat"].HeaderText = "ID du Materiel";
            dataGridView1.Columns["nom"].HeaderText = "Nom";
       //     dataGridView1.Columns["serie"].HeaderText = "Serie";
            dataGridView1.Columns["idClient"].HeaderText = "Id du Client";
            dataGridView1.Columns["photo"].HeaderText = "Photo";

   
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (mater1 != null)
            {
                if (tbxIdmateriel.Text != "")
                {
                    string matricule = tbxIdmateriel.Text;
        //            Factory.getIdByMateriel(matricule);
         //           Factory.updateMateriel(mater1);
                    remplirLaTable();
                    MessageBox.Show("Date well updated");
                }
                else
                {
                    MessageBox.Show($"{tbxNom.Text} is empty");
                }
            }


        }

            private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                mater1 = new Materiel();
                int f = dataGridView1.SelectedRows[0].Index;
                mater1 = (Materiel)listeMateriels[f];
                recuperationMateriel(mater1);


            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tbxIdmateriel != null)
            {
                DialogResult P = MessageBox.Show("Voulez-vous supprimer " + mater1.Nom, " Attention suppression d'un Materiel ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (P == DialogResult.Yes)
                {
                    string matricule = tbxIdmateriel.Text;
         //           Factory.supprimerMateriel(mater1);
                    remplirLaTable();
                    MessageBox.Show("Date well deleted");

                }


            }
        }

        private void tbxIdmateriel_Enter(object sender, EventArgs e)
        {
            string matricule = tbxIdmateriel.Text;
            if (matricule.Trim() == "")
            {
                MessageBox.Show("Tapez d'abord le matricule de ce Materiel");
                tbxIdmateriel.Focus();
            }
            else
            {
         //       mater1 = Factory.getIdByMateriel(matricule);
                if (mater1 != null)
                {
                    recuperationMateriel(mater1);
                    btnAjouter.Enabled = false;
                    MessageBox.Show("Le Materiel ayant ce matricule existe deja");
                }
                else
                {
                    btnAjouter.Enabled = true;
                }
            }
        }
    }
}
