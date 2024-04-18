using Controlleur;
using Modele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Vue
{
    public partial class ucBanque : UserControl
    {
        Banque banque;
        ArrayList listeBanques = new ArrayList();
        public ucBanque()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucBanque_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            banque = saisirBanque();
            Factory.addBanque(banque);
            remplirTable();
            reset();
        }

        public Banque saisirBanque()
        {
            string matricule = tbxIdBanque.Text;
            string nom = tbxNomBanque.Text;
            string Location = tbxLocation.Text;
            string Contact = tbxContact.Text;
            
            Banque banque1 = new Banque(matricule, nom, Location,Contact);

            return banque1;
        }

        void remplirTable()
        {
            listeBanques = Factory.getAllBanque();
            dataGridView1.DataSource = listeBanques;
        }

        void reset()
        {
            tbxIdBanque.Text = "";
            tbxNomBanque.Text = "";
            tbxLocation.Text = "" ;
            tbxContact.Text = "";
        }

        void recuperationBanque(Banque banque)
        {
            tbxIdBanque.Text = banque.IdBanque;
            tbxNomBanque.Text = banque.NomBanque;
            tbxLocation.Text = banque.Location;
            tbxContact.Text = banque.Contact;
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (banque != null)
            {
                if (tbxIdBanque.Text != "")
                {
                    string matricule = tbxIdBanque.Text;
                    Factory.getIdByBanque(matricule);
                    Factory.updateBanque(banque);
                    remplirTable();
                    MessageBox.Show("Date well updated");
                }
                else
                {
                    MessageBox.Show($"{tbxIdBanque.Text} is empty");
                }
            }
            
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            remplirTable();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tbxIdBanque != null)
            {
                DialogResult R = MessageBox.Show("Voulez-vous supprimer " + banque.NomBanque, " Attention suppression d'un cours ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (R == DialogResult.Yes)
                {
                    string matricule = tbxIdBanque.Text;
                    Factory.supprimerBanque(banque);
                    remplirTable();
                    MessageBox.Show("Date well deleted");

                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                banque = new Banque();
                int f = dataGridView1.SelectedRows[0].Index;
                banque = (Banque)listeBanques[f];
                recuperationBanque(banque);


            }
        }
    }
}
