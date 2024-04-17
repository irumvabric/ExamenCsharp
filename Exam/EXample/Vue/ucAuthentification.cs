using Controlleur;
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
    public partial class ucAuthentification : Form
    {
        ArrayList listeNomProfile = new ArrayList();
        public ucAuthentification()
        {
            InitializeComponent();
            listeNomProfile = Factory.ProfileName();
        }
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            comboBoxRole = null;
        }

        private void Connection_Click(object sender, EventArgs e)
        {

        }
        void ChatgerProfileName()
        {
            comboBoxRole.DataSource = listeNomProfile;
            comboBoxRole.DisplayMember = "Nom";

        }
        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string pass = textBox2.Text;
            if (Factory.Connexion(username, pass) == true)
            {
                this.panelDashboard.Controls.Clear();
                ucHome ucHome = new ucHome();
                this.panelDashboard.Controls.Add(ucHome);

            }
            else
            {
                MessageBox.Show("Your inputs are not correct");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
