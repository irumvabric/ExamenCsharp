﻿using System;
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
    public partial class ucHome : UserControl
    {

        private Button btnOK;
        public ucHome()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (btnOK != (Button)btnSender)
                {
                    // DisableButton();
                    // Color color = Color.White;
                    btnOK = (Button)btnSender;
                    btnOK.BackColor = Color.LightCyan;
                    btnOK.ForeColor = Color.FromArgb(35, 124, 210);
                    btnOK.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                }
            }
        }

       /* private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(35, 124, 210);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;

                }
            }
        } */
        private void DashBoard_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            
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
        private void ucHome_Load(object sender, EventArgs e)
        {

        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoard_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucBanque banque = new ucBanque();
            this.panelDashboard.Controls.Add(banque);
        }

        private void buttonOperation_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.panelDashboard.Controls.Clear();
            ucProfile profile = new ucProfile();
            this.panelDashboard.Controls.Add(profile);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOut_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonHistoric_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonUser_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonReport_Click_1(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
