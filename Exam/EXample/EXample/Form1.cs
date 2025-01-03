﻿using System;
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
        private ucAuthentification ucAuthentification ;
     //   ArrayList listeNomProfile = new ArrayList();

        //constructor
        public Form1()
        {
            InitializeComponent();
        //    listeNomProfile = Factory.ProfileName();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  ChatgerProfileName();
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
            foreach (Control previousBtn in panelMenu.Controls) {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(35, 124, 210);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;

                }
            }

            foreach (Control previousBtn in panelBar.Controls)
            {
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

       
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Click_1(object sender, EventArgs e)
        {
           
        }

        private void buttonOperation_Click_1(object sender, EventArgs e)
        {
            
        }


        private void panelDashboard_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
           // this.panelBar.Controls.Clear();
            panelDashboard.Height = 638;
            ucHome hom1 = new ucHome();
            this.panelDashboard.Controls.Add(hom1);
            
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucOperation op1 = new ucOperation();
            this.panelDashboard.Controls.Add(op1);
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            
            ucUtilisateur util1 = new ucUtilisateur();
            this.panelDashboard.Controls.Add(util1);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucAuthentification auth = new ucAuthentification();
            this.Hide();
            auth.Show();
        }

        private void buttonHistoric_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            
        }

        private void ucUser1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonUtilisateurMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonOperationMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBanqueMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCompteMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void panelBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonUtilisateurMenu_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucUtilisateur util1 = new ucUtilisateur();
            this.panelDashboard.Controls.Add(util1);
        }

        private void buttonbuttonProfileMenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucProfile pro = new ucProfile();
            this.panelDashboard.Controls.Add(pro);
        }

        private void buttonOperationMenu_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucOperation op1 = new ucOperation();
            this.panelDashboard.Controls.Add(op1);
        }

        private void buttonCompteMenu_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucCompte compte = new ucCompte();
            this.panelDashboard.Controls.Add(compte);
        }

        private void buttonBanqueMenu_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucBanque banque = new ucBanque();
            this.panelDashboard.Controls.Add(banque);
        }

        private void panelDashboard_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
