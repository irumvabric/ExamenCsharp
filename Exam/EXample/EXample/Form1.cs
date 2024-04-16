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

namespace EXample
{
    public partial class Form1 : Form
    {

        private Button btnOK;
        private Random random;
        private int tempIndex;

        //constructor
        public Form1()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null) {
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
            foreach(Control previousBtn in panelMenu.Controls) {
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

        private void DashBoard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucBanque banque = new ucBanque();
            this.panelDashboard.Controls.Add(banque);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucProfile profile = new ucProfile();
            this.panelDashboard.Controls.Add(profile);
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void buttonHistoric_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
