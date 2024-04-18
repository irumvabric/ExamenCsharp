namespace EXample
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.buttonHistoric = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonOperation = new System.Windows.Forms.Button();
            this.DashBoard = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(124)))), ((int)(((byte)(210)))));
            this.panelMenu.Controls.Add(this.LogOut);
            this.panelMenu.Controls.Add(this.buttonHistoric);
            this.panelMenu.Controls.Add(this.buttonUser);
            this.panelMenu.Controls.Add(this.buttonReport);
            this.panelMenu.Controls.Add(this.buttonOperation);
            this.panelMenu.Controls.Add(this.DashBoard);
            this.panelMenu.Controls.Add(this.panelHeader);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 638);
            this.panelMenu.TabIndex = 4;
            // 
            // LogOut
            // 
            this.LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOut.Image = global::EXample.Properties.Resources.Open_Pane1;
            this.LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.Location = new System.Drawing.Point(0, 383);
            this.LogOut.Name = "LogOut";
            this.LogOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.LogOut.Size = new System.Drawing.Size(220, 57);
            this.LogOut.TabIndex = 6;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // buttonHistoric
            // 
            this.buttonHistoric.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHistoric.FlatAppearance.BorderSize = 0;
            this.buttonHistoric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistoric.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistoric.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHistoric.Image = global::EXample.Properties.Resources.Graph_Report1;
            this.buttonHistoric.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistoric.Location = new System.Drawing.Point(0, 326);
            this.buttonHistoric.Name = "buttonHistoric";
            this.buttonHistoric.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonHistoric.Size = new System.Drawing.Size(220, 57);
            this.buttonHistoric.TabIndex = 5;
            this.buttonHistoric.Text = "Historic";
            this.buttonHistoric.UseVisualStyleBackColor = true;
            this.buttonHistoric.Click += new System.EventHandler(this.buttonHistoric_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUser.Image = global::EXample.Properties.Resources.User1;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.Location = new System.Drawing.Point(0, 269);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonUser.Size = new System.Drawing.Size(220, 57);
            this.buttonUser.TabIndex = 4;
            this.buttonUser.Text = "Users        ";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReport.Image = global::EXample.Properties.Resources.Graph_Report1;
            this.buttonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.Location = new System.Drawing.Point(0, 212);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonReport.Size = new System.Drawing.Size(220, 57);
            this.buttonReport.TabIndex = 3;
            this.buttonReport.Text = "Report      ";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonOperation
            // 
            this.buttonOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOperation.FlatAppearance.BorderSize = 0;
            this.buttonOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperation.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOperation.Image = global::EXample.Properties.Resources.Transaction_List;
            this.buttonOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOperation.Location = new System.Drawing.Point(0, 155);
            this.buttonOperation.Name = "buttonOperation";
            this.buttonOperation.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonOperation.Size = new System.Drawing.Size(220, 57);
            this.buttonOperation.TabIndex = 2;
            this.buttonOperation.Text = "     Operation";
            this.buttonOperation.UseVisualStyleBackColor = true;
            this.buttonOperation.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // DashBoard
            // 
            this.DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashBoard.FlatAppearance.BorderSize = 0;
            this.DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoard.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DashBoard.Image = global::EXample.Properties.Resources.Home2;
            this.DashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBoard.Location = new System.Drawing.Point(0, 98);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DashBoard.Size = new System.Drawing.Size(220, 57);
            this.DashBoard.TabIndex = 1;
            this.DashBoard.Text = "       Dashboard";
            this.DashBoard.UseVisualStyleBackColor = true;
            this.DashBoard.Click += new System.EventHandler(this.DashBoard_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(220, 98);
            this.panelHeader.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::EXample.Properties.Resources.FinApp__1_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 57);
            this.button1.TabIndex = 7;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashboard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDashboard.Location = new System.Drawing.Point(219, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1042, 638);
            this.panelDashboard.TabIndex = 5;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 638);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDashboard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOperation;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button buttonHistoric;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button DashBoard;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDashboard;
    }
}

