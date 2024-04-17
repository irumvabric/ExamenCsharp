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
    public partial class ucUtilisateur : UserControl
    {
        utilisateur user = null;
        ArrayList listeUtilisateur = null;
        ArrayList listeProfile = null;

        public ucUtilisateur()
        {
            InitializeComponent();
            listeProfile = Factory.ProfileName();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSalaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ucUser1_Load(object sender, EventArgs e)
        {

        }
        void ChatgerProfileName()
        {
            comboBox1.DataSource = listeProfile;
            comboBox1.DisplayMember = "Nom";

        }

        void remplirTable() {
            listeUtilisateur = Factory.getAllUsers();
            dataGridView1.DataSource = listeUtilisateur;
        }

        void reset()
        {
            tbxNomUtilisateur.Text = " ";
            tbxPrenom.Text= " ";
            tbxIdUtilisateur.Text = "";
            tbxNom.Text = "";
            comboBox1.Text = " ";
            tbxMotDePasse.Text = "";

        }

        void recuperationUtilisateur(utilisateur user)
        {
            tbxMotDePasse.Text = user.Password;
            tbxNomUtilisateur.Text = user.Username;
            tbxPrenom.Text = user.Prenom;
            tbxIdUtilisateur.Text = user.IdUtilisateur;
            tbxMotDePasse.Text = user.Password;
            tbxNom.Text = user.Nom;
            comboBox1.Text = user.NomProfile;
        }
        public utilisateur saisirUtilisateur()
        {

            string nom = tbxNom.Text;
            string nomProfile = comboBox1.Text;
            string idUtilisateur = tbxIdUtilisateur.Text;
            string motDePasse = tbxMotDePasse.Text;
            string prenom = tbxPrenom.Text;
            string nomUtilisateur = tbxNomUtilisateur.Text;


          //  string matricule = getIdTechnitien(nom);

            utilisateur user = new utilisateur(idUtilisateur, nom, prenom,nomUtilisateur,motDePasse,nomProfile);

            return user;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            remplirTable();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            user = saisirUtilisateur();
            Factory.addUtilisateur(user);
            reset();
            remplirTable();
        }

        private void ucUtilisateur_Load(object sender, EventArgs e)
        {
            ChatgerProfileName();
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                user = new utilisateur();
                int f = dataGridView1.SelectedRows[0].Index;
                user = (utilisateur)listeUtilisateur[f];
                recuperationUtilisateur(user);


            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tbxIdUtilisateur != null)
            {
                DialogResult P = MessageBox.Show("Voulez-vous supprimer " + user.Nom, " Attention suppression d'un Materiel ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (P == DialogResult.Yes)
                {
                    string matricule = tbxIdUtilisateur.Text;
                    Factory.supprimerutilisateur(user);
                    remplirTable();
                    MessageBox.Show("Date well deleted");

                }


            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                if (tbxIdUtilisateur.Text != "")
                {
                    string matricule = tbxIdUtilisateur.Text;
                    Factory.getIdByUtilisateur(matricule);
                    Factory.updateUtilisateurs(user);
                    remplirTable();
                    MessageBox.Show("Date well updated");
                }
                else
                {
                    MessageBox.Show($"{tbxNom.Text} is empty");
                }
            }
        }
    }
}
