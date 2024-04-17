namespace Vue
{
    partial class ucHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.buttonHistoric = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonOperation = new System.Windows.Forms.Button();
            this.DashBoard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panelMenu.TabIndex = 2;
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
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDashboard.Location = new System.Drawing.Point(223, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1067, 638);
            this.panelDashboard.TabIndex = 3;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // LogOut
            // 
            this.LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOut.Image = global::Vue.Properties.Resources.Open_Pane;
            this.LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.Location = new System.Drawing.Point(0, 383);
            this.LogOut.Name = "LogOut";
            this.LogOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.LogOut.Size = new System.Drawing.Size(220, 57);
            this.LogOut.TabIndex = 6;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // buttonHistoric
            // 
            this.buttonHistoric.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHistoric.FlatAppearance.BorderSize = 0;
            this.buttonHistoric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistoric.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistoric.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHistoric.Image = global::Vue.Properties.Resources.Activity_History;
            this.buttonHistoric.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistoric.Location = new System.Drawing.Point(0, 326);
            this.buttonHistoric.Name = "buttonHistoric";
            this.buttonHistoric.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonHistoric.Size = new System.Drawing.Size(220, 57);
            this.buttonHistoric.TabIndex = 5;
            this.buttonHistoric.Text = "Historic";
            this.buttonHistoric.UseVisualStyleBackColor = true;
            // 
            // buttonUser
            // 
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUser.Image = global::Vue.Properties.Resources.User;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.Location = new System.Drawing.Point(0, 269);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonUser.Size = new System.Drawing.Size(220, 57);
            this.buttonUser.TabIndex = 4;
            this.buttonUser.Text = "Users        ";
            this.buttonUser.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReport.Image = global::Vue.Properties.Resources.Graph_Report;
            this.buttonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.Location = new System.Drawing.Point(0, 212);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonReport.Size = new System.Drawing.Size(220, 57);
            this.buttonReport.TabIndex = 3;
            this.buttonReport.Text = "Report      ";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonOperation
            // 
            this.buttonOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOperation.FlatAppearance.BorderSize = 0;
            this.buttonOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperation.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOperation.Image = global::Vue.Properties.Resources.Transaction_List;
            this.buttonOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOperation.Location = new System.Drawing.Point(0, 155);
            this.buttonOperation.Name = "buttonOperation";
            this.buttonOperation.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonOperation.Size = new System.Drawing.Size(220, 57);
            this.buttonOperation.TabIndex = 2;
            this.buttonOperation.Text = "     Operation";
            this.buttonOperation.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashBoard.FlatAppearance.BorderSize = 0;
            this.DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoard.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DashBoard.Image = global::Vue.Properties.Resources.Home;
            this.DashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBoard.Location = new System.Drawing.Point(0, 98);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DashBoard.Size = new System.Drawing.Size(220, 57);
            this.DashBoard.TabIndex = 1;
            this.DashBoard.Text = "       Dashboard";
            this.DashBoard.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::Vue.Properties.Resources.FinApp__1_;
            this.button1.Location = new System.Drawing.Point(-3, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 57);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDashboard);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1316, 638);
            this.Load += new System.EventHandler(this.ucHome_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button buttonHistoric;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonOperation;
        private System.Windows.Forms.Button DashBoard;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Button button1;
    }
}
