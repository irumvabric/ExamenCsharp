namespace Vue
{
    partial class ucUser
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
            this.buttonUtilisateur = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUtilisateur
            // 
            this.buttonUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(124)))), ((int)(((byte)(210)))));
            this.buttonUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilisateur.ForeColor = System.Drawing.Color.White;
            this.buttonUtilisateur.Location = new System.Drawing.Point(314, 53);
            this.buttonUtilisateur.Name = "buttonUtilisateur";
            this.buttonUtilisateur.Size = new System.Drawing.Size(137, 44);
            this.buttonUtilisateur.TabIndex = 3;
            this.buttonUtilisateur.Text = "Utilisateur";
            this.buttonUtilisateur.UseVisualStyleBackColor = false;
            this.buttonUtilisateur.Click += new System.EventHandler(this.buttonUtilisateur_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(124)))), ((int)(((byte)(210)))));
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.Color.White;
            this.buttonProfile.Location = new System.Drawing.Point(492, 53);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(137, 44);
            this.buttonProfile.TabIndex = 4;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonUtilisateur);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(1107, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUtilisateur;
        private System.Windows.Forms.Button buttonProfile;
    }
}
