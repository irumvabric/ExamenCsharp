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

namespace Vue
{
    public partial class ucReparation : UserControl
    {

        ArrayList listeClients = new ArrayList();
        ArrayList listeMateriels = new ArrayList();
        ArrayList listeReparations = new ArrayList();

        Reparation repar1 = new Reparation();
        public ucReparation()
        {
            InitializeComponent();
        //    listeClients = Factory.getAllClients();
         //   listeMateriels = Factory.getAllMateriel();
        }

        void ChargerClients()
        {
            comboBoxClient.DataSource = listeClients;
            comboBoxClient.DisplayMember = "IdentificationComplete";
        }

        void ChargerMateriel()
        {
            comboBoxMateriel.DataSource = listeMateriels;
            comboBoxMateriel.DisplayMember = "IdentifMatriComplete";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxPanne_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCout_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
    //        Factory.addReparation(saisirReparation());
            FillTable();
            reset();
        }

        void reset()
        {
            tbxCout.Text ="";
            tbxPanne.Text = "";
        }

        public Reparation saisirReparation()
        {
            repar1.Cout = int.Parse(tbxCout.Text);
            repar1.Date = DateTime.Parse(dateTimePicker1.Text);
            repar1.Panne = tbxPanne.Text;

            int indexMateriel = comboBoxClient.SelectedIndex;
            repar1.IdMateriel = ((Materiel)listeMateriels[indexMateriel]).Idmat;

            int indexClient = comboBoxMateriel.SelectedIndex;
            repar1.IdClient = ((Client)listeClients[indexClient]).Matricule;

            return repar1;
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        void FillTable()
        {
       //     listeReparations = Factory.getAllReparation();
            dataGridView2.DataSource = listeReparations;

            dataGridView2.Columns["date"].DisplayIndex = 4;
            dataGridView2.Columns["panne"].DisplayIndex = 1;
            dataGridView2.Columns["cout"].DisplayIndex = 2;
         //   dataGridView2.Columns["idMat"].DisplayIndex = 3;
            dataGridView2.Columns["idClient"].DisplayIndex = 0;

            dataGridView2.Columns["date"].HeaderText = "Date";
            dataGridView2.Columns["panne"].HeaderText = "Panne";
            dataGridView2.Columns["cout"].HeaderText = "Coût";
       //     dataGridView2.Columns["idMat"].HeaderText = "ID du Matériel";
            dataGridView2.Columns["idClient"].HeaderText = "ID du Client";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (repar1 != null)
            {
                if (comboBoxClient.Text != "" && comboBoxMateriel.Text != "")
                {
                    string idMateriel = comboBoxMateriel.Text;
                    string idClientok = comboBoxClient.Text;

                 //   repar1 = Factory.getIdByReparation(idMateriel, idClientok);
                //    Factory.updateReparation(repar1, idMateriel,idClientok);
                    FillTable();
                    MessageBox.Show("Date well updated");
                }
                else
                {
                    MessageBox.Show($"{comboBoxClient.Text} and {comboBoxMateriel.Text} is empty");
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucReparation_Load(object sender, EventArgs e)
        {
            ChargerClients();
            ChargerMateriel();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                repar1 = new Reparation();
                int i = dataGridView2.SelectedRows[0].Index;
                repar1 = (Reparation)listeReparations[i];
                recuperationReparation(repar1 );
            }
        }

        void recuperationReparation(Reparation reparationRecuperer)
        {
            tbxCout.Text = reparationRecuperer.Cout.ToString();
            tbxPanne.Text = reparationRecuperer.Panne;
            dateTimePicker1.Value = reparationRecuperer.Date;
            comboBoxClient.Text = reparationRecuperer.IdClient;
            comboBoxMateriel.Text = reparationRecuperer.IdMateriel;
            dateTimePicker1.Value = reparationRecuperer.Date;
   

        }
    }
}
