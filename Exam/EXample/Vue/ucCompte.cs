using Controlleur;
using Modele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vue
{
    public partial class ucCompte : UserControl
    {
        ArrayList Listecomptes= new ArrayList();
        Compte compteUn = new Compte(); 
        ArrayList listesBanques= new ArrayList();
        public ucCompte()
        {
            InitializeComponent();
            listesBanques = Factory.getAllBanque();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            compteUn = SaisirCompte();
            Factory.addCompte(compteUn);
            remplirTable();
            reset();
        }

        public Compte SaisirCompte()
        {
            string idCompte = tbxIdCompte.Text;
            string idBanque = cbxBanque.Text;
            string typeCompte = comboBoxCompte.Text;
            int solde = int.Parse(textBoxSolde.Text);

            compteUn = new Compte(idCompte, typeCompte,idBanque, solde);

            return compteUn;

        }

        void remplirTable()
        {
            Listecomptes = Factory.getAllCompte();
            dataGridView1.DataSource = Listecomptes;

        }

        void reset()
        {
            tbxIdCompte.Text = "";
            cbxBanque.Text = "";
            comboBoxCompte.Text = "";
            textBoxSolde.Text = "";
        }
        private void ucCompte_Load(object sender, EventArgs e)
        {
            ChargerBanque();
        }

        void ChargerBanque()
        {
                cbxBanque.DataSource = listesBanques;
                cbxBanque.DisplayMember = "IdCompleteBanque";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            remplirTable();
        }

        void recuperationCompte(Compte co1)
        {
            tbxIdCompte.Text = co1.IdCompte.ToString();
            comboBoxCompte.Text = co1.TypeDeCompte.ToString();
            textBoxSolde.Text = co1.Solde.ToString();
            cbxBanque.Text = co1.IdBanqueCompte.ToString();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tbxIdCompte != null)
            {
                DialogResult R = MessageBox.Show("Voulez-vous supprimer " + tbxIdCompte.Text, " Attention suppression d'un cours ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (R == DialogResult.Yes)
                {
                    string matricule = tbxIdCompte.Text;
                    Factory.supprimerCompte(matricule);
                    remplirTable();
                    MessageBox.Show("Date well deleted");

                }
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (compteUn != null)
            {
                if (tbxIdCompte.Text != "")
                {
                    string matricule = tbxIdCompte.Text;
                    compteUn = Factory.getIdByCompte(matricule);
                    Factory.updateCompte(compteUn);
                    remplirTable();
                    MessageBox.Show("Date well updated");
                }
                else
                {
                    MessageBox.Show($"{tbxIdCompte.Text} is empty");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                compteUn = new Compte();
                int f = dataGridView1.SelectedRows[0].Index;
                compteUn = (Compte)Listecomptes[f];
                recuperationCompte(compteUn);


            }
        }
    }
}
