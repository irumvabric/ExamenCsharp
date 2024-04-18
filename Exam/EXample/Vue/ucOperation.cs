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
    public partial class ucOperation : UserControl
    {
        ArrayList listeCompte = new ArrayList();
        ArrayList listeOperation = new ArrayList();
        Operation operation1 = new Operation();
        public ucOperation()
        {
            InitializeComponent();
            listeCompte = Factory.getAllCompte();
        }


        void ChargerCompte()
        {
            cbxidCompte.DataSource = listeCompte;
            cbxidCompte.DisplayMember = "idCompte";
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSalaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            operation1 = saisirOperation();
            Factory.addOperation(operation1);
            remplirTable();
            reset();
        }

        private void ucTitleCompte1_Load(object sender, EventArgs e)
        {

        }

        private void ucOperation_Load(object sender, EventArgs e)
        {
            ChargerCompte();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (operation1 != null)
            {
                if (tbxIdOp.Text != "")
                {
                    string matricule = tbxIdOp.Text;
                    Factory.getIdByOperation(matricule);
                    Factory.updateOperation(operation1);
                    remplirTable();
                    MessageBox.Show("Date well updated");
                }
                else
                {
                    MessageBox.Show($"{tbxIdOp.Text} is empty");
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

        void remplirTable()
        {
            listeOperation = Factory.getAllOperation();
            dataGridView1.DataSource = listeOperation;
        }

        public Operation saisirOperation()
        {
            string matricule = tbxIdOp.Text;
            string Compte = cbxidCompte.Text;
            string libele = rtbxdesc.Text;
            DateTime date = dateTimePicker1.Value;
            string TypeOperation = comboBoxOperation.Text;
            int solde = int.Parse(textBoxMontant.Text);


            operation1 = new Operation(matricule,Compte,libele,TypeOperation,date,solde);
            
            return operation1;
        }
        void reset()
        {
            tbxIdOp.Text = "";
            cbxidCompte.Text = "";
            rtbxdesc.Text = "";
            textBoxMontant.Text = "";
            comboBoxOperation.Text = "";
          //  dateTimePicker1.Value = null;
        }

        void recuperationOp(Operation op)
        {
            tbxIdOp.Text = op.IdOperation;
            cbxidCompte.Text = op.IdCompte;
            rtbxdesc.Text = op.Libele;
            textBoxMontant.Text = op.Fond.ToString();
            comboBoxOperation.Text = op.IdOperation;
            //  dateTimePicker1.Value = null;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tbxIdOp != null)
            {
                DialogResult P = MessageBox.Show("Voulez-vous supprimer " + operation1.IdOperation, " Attention suppression d'un Materiel ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (P == DialogResult.Yes)
                {
                    string matricule = tbxIdOp.Text;
                    Factory.getIdByOperation(matricule);
                    Factory.supprimerOperation(operation1);

                    MessageBox.Show("Date well deleted");
                    remplirTable();

                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                operation1 = new Operation();
                int f = dataGridView1.SelectedRows[0].Index;
                operation1 = (Operation)listeOperation[f];
                recuperationOp(operation1);


            }
        }
    }
}
