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
    public partial class ucProfile : UserControl
    {
        Profile prof;
        ArrayList listeProfile = new ArrayList();
        public ucProfile()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucProfile_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   string matri = tbxIdmateriel.Text;
            prof = saisirProfile();
            Factory.addProfiles(prof);
            remplirLatable();
            reset();
        }

        public Profile saisirProfile()
        {
            Profile profile = new Profile();

            profile.Id = tbxId.Text;
            profile.Nom = textBox1.Text;
            profile.Salaire = int.Parse(textBoxSalaire.Text);            
            profile.Privilege = tbxPrivileges.Text;

            return profile;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (prof != null)

            {
                if (tbxId.Text != "")
                {
                    string matricule = tbxId.Text;
                    Factory.getIdByProfile(matricule);
                    Factory.updateProfile(prof);
                    remplirLatable();
                    MessageBox.Show("Date well updated");
                }
                else
                {
                    MessageBox.Show($"{textBox1.Text} is empty");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            remplirLatable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbxId != null)
            {
                DialogResult P = MessageBox.Show("Voulez-vous supprimer " + prof.Nom, " Attention suppression d'un Materiel ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (P == DialogResult.Yes)
                {
                    string matricule = tbxId.Text;
                    Factory.supprimerprofile(prof);
                    remplirLatable();
                    MessageBox.Show("Date well deleted");

                }


            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        void reset()
        {
            tbxId.Text = "";
            tbxPrivileges.Text = "";
            textBox1.Text = "";
            textBoxSalaire.Text = "";
        }

        void remplirLatable()
        {
            listeProfile = Factory.getAllProfiles();
            dataGridView1.DataSource = listeProfile;    
        }

        void recuperationProfile(Profile pro)
        {
            tbxId.Text = pro.Id;
            tbxPrivileges.Text = pro.Privilege;
            textBox1.Text = pro.Nom; 
            textBoxSalaire.Text = pro.Salaire.ToString(); 
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void ucUser1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                prof = new Profile();
                int f = dataGridView1.SelectedRows[0].Index;
                prof = (Profile)listeProfile[f];
                recuperationProfile(prof);

            }
        }
    }
}
