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
using Modele;
using Controlleur;



namespace Vue
{
    public partial class ucClient : UserControl
    {
        
        Client cl1 = null;
        ArrayList listeClients = new ArrayList();   
        
        public ucClient()
        {
            InitializeComponent();
        }

        private void ucClient_Load(object sender, EventArgs e)
        {

        }

        private void tbxClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void radHomme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radFemme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbxTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           // Factory.addClients(saisirClient());
            remplirLaTable();
            reset();
        }

        public Client saisirClient()
        {

            
            string matricule = tbxClient.Text;
            string nom = tbxNom.Text;
            string genre = "";
            string telephone = tbxTelephone.Text;
            string email = tbxEmail.Text;
            string nationalite = tbxNationalite.Text;

            foreach (Control ctrl in groupBox1.Controls)
            {
                if (((RadioButton)ctrl).Checked)
                {
                    genre = ((RadioButton)ctrl).Text;
                    break;
                }
            }

            Client Cl1 = new Client(matricule, nom, nationalite, telephone, email, genre);

            return Cl1;
        }

        void remplirLaTable() 
        {
       //     dataGridView1.DataSource = Factory.getAllClients();

            dataGridView1.Columns["nom"].DisplayIndex = 2;
            dataGridView1.Columns["nationalite"].DisplayIndex = 1;
            dataGridView1.Columns["genre"].DisplayIndex = 3;
            dataGridView1.Columns["tel"].DisplayIndex = 5;
            dataGridView1.Columns["email"].DisplayIndex = 4;
            dataGridView1.Columns["idClient"].DisplayIndex = 1;

            dataGridView1.Columns["nom"].HeaderText = "Nom";
            dataGridView1.Columns["nationalite"].HeaderText = "Nationalité";
            dataGridView1.Columns["genre"].HeaderText = "Genre";
            dataGridView1.Columns["tel"].HeaderText = "Téléphone";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["idClient"].HeaderText = "ID du Client";

            dataGridView1.BackgroundColor = Color.Black;

            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            afficherClient();


        }


        void afficherClient()
        {
         //   listeClients = Factory.getAllClients();
            dataGridView1.DataSource = listeClients;

            dataGridView1.Columns["nom"].DisplayIndex = 2;
            dataGridView1.Columns["nationalite"].DisplayIndex = 1;
            dataGridView1.Columns["genre"].DisplayIndex = 3;
      //      dataGridView1.Columns["tel"].DisplayIndex = 5;
            dataGridView1.Columns["email"].DisplayIndex = 4;
     //       dataGridView1.Columns["idClient"].DisplayIndex = 1;

            dataGridView1.Columns["nom"].HeaderText = "Nom";
            dataGridView1.Columns["nationalite"].HeaderText = "Nationalité";
            dataGridView1.Columns["genre"].HeaderText = "Genre";
      //      dataGridView1.Columns["tel"].HeaderText = "Téléphone";
            dataGridView1.Columns["email"].HeaderText = "Email";
       //     dataGridView1.Columns["idClient"].HeaderText = "ID du Client";


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        void reset()
        {
            tbxClient.Text = "";
            tbxNom.Text = "";
            tbxTelephone.Text = "";
            tbxEmail.Text = "";
            tbxNationalite.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(cl1 != null) {
                if (tbxClient.Text != "")
                {
                    string matricule = tbxClient.Text;
            //        Factory.getIdByClient(matricule);
            //        Factory.updateClients(cl1);
                    remplirLaTable();
                    MessageBox.Show("Date well updated");
                }
                else
                {
                    MessageBox.Show($"{tbxClient.Text} is empty");
                }
                
                
            }
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            if(tbxClient.Text != "") {
            //    cl1 = Factory.getIdByClient(tbxClient.Text);
                recuperationClient(cl1);
            }
            else
            {
                MessageBox.Show($"{tbxClient.Text} is empty");
            }
        }

        void recuperationClient(Client client)
        {
            tbxClient.Text = client.Matricule;
            tbxNom.Text = client.Nom;
            tbxTelephone.Text = client.Telephone;
            tbxEmail.Text = client.Email;
            tbxNationalite.Text = client.Nationalite;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(tbxClient  != null) {
                DialogResult R = MessageBox.Show("Voulez-vous supprimer "+cl1.Email," Attention suppression d'un cours ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                
                if(R == DialogResult.Yes)
                {
                    string matricule = tbxClient.Text;  
            //        Factory.supprimerClient(cl1);
                    remplirLaTable();
                    MessageBox.Show("Date well deleted");

                }


            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                cl1 = new Client();
                int f = dataGridView1.SelectedRows[0].Index;
                cl1 = (Client)listeClients[f];
                recuperationClient(cl1);


            }
        }

        private void tbxClient_Enter(object sender, EventArgs e)
        {
            string matricule = tbxClient.Text;
            if (matricule.Trim() == "")
            {
                MessageBox.Show("Tapez d'abord le matricule de ce Client");
                tbxClient.Focus();
            }
            else
            {
       //         cl1 = Factory.getIdByClient(matricule);
                if (cl1 != null)
                {
                    recuperationClient(cl1);
                    btnSave.Enabled = false;
                    MessageBox.Show("Le Client ayant ce matricule existe deja");
                }
                else
                {
                    btnSave.Enabled = true;
                }
            }
        }
    }
}
