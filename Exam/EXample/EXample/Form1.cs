using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vue;
using Controlleur;
using System.Collections;

namespace EXample
{
    public partial class Form1 : Form
    {

        private Button btnOK;
        private Random random;
        private int tempIndex;
        ArrayList listeNomProfile = new ArrayList();

        //constructor
        public Form1()
        {
            InitializeComponent();
            listeNomProfile = Factory.ProfileName();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) {
                if (btnOK != (Button)btnSender)
                {
                    DisableButton();
                    // Color color = Color.White;
                    btnOK = (Button)btnSender;
                    btnOK.BackColor = Color.LightCyan;
                    btnOK.ForeColor = Color.FromArgb(35, 124, 210);
                    btnOK.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls) {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(35, 124, 210);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;

                }
            }
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelDashboard.Controls.Clear();
            ucClient frmclient = new ucClient();
            this.panelDashboard.Controls.Add(frmclient);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void technicienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelDashboard.Controls.Clear();
            ucTechnicien frmtechn = new ucTechnicien();
            this.panelDashboard.Controls.Add(frmtechn);
        }

        private void materielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelDashboard.Controls.Clear();
            ucMateriel frmmateriel = new ucMateriel();
            this.panelDashboard.Controls.Add(frmmateriel);
        }

        private void reparationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelDashboard.Controls.Clear();
            ucReparation frmReparation = new ucReparation();
            this.panelDashboard.Controls.Add(frmReparation);
        }



        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChatgerProfileName();
        }

        void ChatgerProfileName(){
            comboBoxRole.DataSource = listeNomProfile;
         }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            if (Factory.Connexion(username,pass) == true)
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

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
