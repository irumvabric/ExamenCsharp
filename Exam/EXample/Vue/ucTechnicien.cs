using Modele;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Vue
{
    public partial class ucTechnicien : UserControl
    {

        Techniciens tech1 = null;
        ArrayList listeTech = null;
        public ucTechnicien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ucTechnicien_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbxMatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateNaiss_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateEmbouche_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxNationalite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxGenre_Enter(object sender, EventArgs e)
        {

        }

        private void radHomme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radFemme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tech1 = saisirTechnitien();
            //        Factory.addTechniciens(tech1);
            SalaireTbx.Text = tech1.Salaire.ToString();
            remplirLaTable();
            reset();
        }


        public Techniciens saisirTechnitien()
        {

            string nom = tbxNom.Text;
            string genre = "";
            string telephone = tbxTelephone.Text;
            string email = tbxEmail.Text;
            string nationalite = cbxNationalite.Text;

            foreach (Control ctrl in gbxGenre.Controls)
            {
                if (radFemme.Checked)
                {
                    genre = radFemme.Text;

                }
                else
                {
                    genre = radHomme.Text;
                }
            }

            DateTime dE = dateTimePickerDateEmbouche.Value;
            DateTime dn = dateTimePickerDateNaiss.Value;
            string dipl = comboBoxDiplome.Text;
            string matricule = getIdTechnitien(nom);

            Techniciens tech1 = new Techniciens(matricule, nom, nationalite, telephone, email, genre, dE, dn, dipl);

            return tech1;
        }

        void remplirLaTable()
        {
            //     listeTech = Factory.getAlltechniciens();
            dataGridView1.DataSource = listeTech;

            dataGridView1.Columns["matricule"].DisplayIndex = 0;
            dataGridView1.Columns["nom"].DisplayIndex = 1;
            //     dataGridView1.Columns["dateNaissance"].DisplayIndex = 2;
            //     dataGridView1.Columns["dateEmbauche"].DisplayIndex = 3;
            dataGridView1.Columns["nationalite"].DisplayIndex = 4;
            dataGridView1.Columns["telephone"].DisplayIndex = 5;
            dataGridView1.Columns["email"].DisplayIndex = 6;
            dataGridView1.Columns["genre"].DisplayIndex = 7;
            dataGridView1.Columns["diplome"].DisplayIndex = 8;

            dataGridView1.Columns["matricule"].HeaderText = "Matricule";
            dataGridView1.Columns["nom"].HeaderText = "Nom";
            //     dataGridView1.Columns["dateNaissance"].HeaderText = "Date de Naissance";
            //     dataGridView1.Columns["dateEmbauche"].HeaderText = "Date d'Embauche";
            dataGridView1.Columns["nationalite"].HeaderText = "Nationalité";
            dataGridView1.Columns["telephone"].HeaderText = "Téléphone";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["genre"].HeaderText = "Genre";
            dataGridView1.Columns["diplome"].HeaderText = "Diplôme";

        }



        void reset()
        {
            tbxMatricule.Text = "";
            tbxNom.Text = "";
            tbxTelephone.Text = "";
            tbxEmail.Text = "";
            cbxNationalite.Text = "";
            dateTimePickerDateEmbouche = null;
            dateTimePickerDateNaiss = null;
            comboBoxDiplome.Text = "";
            SalaireTbx.Text = "";
            btnSave.Enabled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            afficherTechnitien();
        }

        void afficherTechnitien()
        {
            //     listeTech = Factory.getAlltechniciens();
            dataGridView1.DataSource = listeTech;

            dataGridView1.Columns["matricule"].DisplayIndex = 0;
            dataGridView1.Columns["nom"].DisplayIndex = 1;
            //     dataGridView1.Columns["dateNaissance"].DisplayIndex = 2;
            //     dataGridView1.Columns["dateEmbauche"].DisplayIndex = 3;
            dataGridView1.Columns["nationalite"].DisplayIndex = 4;
            dataGridView1.Columns["telephone"].DisplayIndex = 5;
            dataGridView1.Columns["email"].DisplayIndex = 6;
            dataGridView1.Columns["genre"].DisplayIndex = 7;
            dataGridView1.Columns["diplome"].DisplayIndex = 8;

            dataGridView1.Columns["matricule"].HeaderText = "Matricule";
            dataGridView1.Columns["nom"].HeaderText = "Nom";
            //    dataGridView1.Columns["dateNaissance"].HeaderText = "Date de Naissance";
            //    dataGridView1.Columns["dateEmbauche"].HeaderText = "Date d'Embauche";
            dataGridView1.Columns["nationalite"].HeaderText = "Nationalité";
            dataGridView1.Columns["telephone"].HeaderText = "Téléphone";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["genre"].HeaderText = "Genre";
            dataGridView1.Columns["diplome"].HeaderText = "Diplôme";
        }

        void recuperationTech(Techniciens techniciens)
        {
            tbxMatricule.Text = techniciens.Matricule;
            tbxNom.Text = techniciens.Nom;
            tbxTelephone.Text = techniciens.Telephone;
            tbxEmail.Text = techniciens.Email;
            cbxNationalite.Text = techniciens.Nationalite;
            SalaireTbx.Text = techniciens.Salaire.ToString();
            dateTimePickerDateEmbouche.Value = techniciens.DateEmbauche;
            dateTimePickerDateNaiss.Value = techniciens.DateNaiss;
            comboBoxDiplome.Text = techniciens.Diplome;
            SalaireTbx.Text = tech1.Salaire.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tech1 = new Techniciens();
                int f = dataGridView1.SelectedRows[0].Index;
                tech1 = (Techniciens)listeTech[f];
                recuperationTech(tech1);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tbxMatricule != null)
            {
                DialogResult R = MessageBox.Show("Voulez-vous supprimer " + tech1.Nom, " Attention suppression d'un Technitien ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (R == DialogResult.Yes)
                {
                    string matricule = tbxMatricule.Text;
                    //            Factory.supprimerTechnicien(tech1);
                    remplirLaTable();
                    MessageBox.Show("Date well deleted");

                }


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tech1 != null)
            {
                if (tbxMatricule.Text != "")
                {
                    string matricule = tbxMatricule.Text;
                    //           Factory.getIdByTech(matricule);
                    //           Factory.updateTechnicien(tech1);
                    SalaireTbx.Text = tech1.Salaire.ToString();
                    remplirLaTable();
                    MessageBox.Show("Date well updated");
                }
                else
                {
                    MessageBox.Show($"{tbxNom.Text} is empty");
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDiplome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxMatricule_Enter(object sender, EventArgs e)
        {
            string matricule = tbxMatricule.Text;
            if (matricule.Trim() == "")
            {
                MessageBox.Show("Tapez d'abord le matricule de Technitien");
                tbxMatricule.Focus();
            }
            else
            {
                //       tech1 = Factory.getIdByTech(matricule); 
                if (tech1 != null)
                {
                    recuperationTech(tech1);
                    btnSave.Enabled = false;
                    MessageBox.Show("Le technitien ayant ce matricule existe deja");
                }
                else
                {
                    btnSave.Enabled = true;
                }
            }
        }


        private string getIdTechnitien(string nom)
        {
            //   listeTech = Factory.getAllClients();
            string s = "";
            DateTime t = DateTime.Today;
            int y = t.Year;
            string year = y.ToString();
            int ordId = listeTech.Count + 1;

            string ord1 = ordId.ToString();


            s = "T-" + nom.Substring(0, 2) + "-" + ord1 + "-" + year;
            return s;
        }

        private void comboBoxDiplome_Leave(object sender, EventArgs e)
        {

        }
    }
}
