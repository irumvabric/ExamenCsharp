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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donneeDeBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traitementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMaterielRepareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donneeDeBaseToolStripMenuItem,
            this.traitementToolStripMenuItem,
            this.rapportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // donneeDeBaseToolStripMenuItem
            // 
            this.donneeDeBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.technicienToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.materielToolStripMenuItem});
            this.donneeDeBaseToolStripMenuItem.Name = "donneeDeBaseToolStripMenuItem";
            this.donneeDeBaseToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.donneeDeBaseToolStripMenuItem.Text = "Donnee de base";
            // 
            // technicienToolStripMenuItem
            // 
            this.technicienToolStripMenuItem.Name = "technicienToolStripMenuItem";
            this.technicienToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.technicienToolStripMenuItem.Text = "Technicien";
            this.technicienToolStripMenuItem.Click += new System.EventHandler(this.technicienToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clientToolStripMenuItem.Text = "client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // materielToolStripMenuItem
            // 
            this.materielToolStripMenuItem.Name = "materielToolStripMenuItem";
            this.materielToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.materielToolStripMenuItem.Text = "materiel";
            this.materielToolStripMenuItem.Click += new System.EventHandler(this.materielToolStripMenuItem_Click);
            // 
            // traitementToolStripMenuItem
            // 
            this.traitementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reparationToolStripMenuItem1});
            this.traitementToolStripMenuItem.Name = "traitementToolStripMenuItem";
            this.traitementToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.traitementToolStripMenuItem.Text = "Traitement";
            // 
            // reparationToolStripMenuItem1
            // 
            this.reparationToolStripMenuItem1.Name = "reparationToolStripMenuItem1";
            this.reparationToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.reparationToolStripMenuItem1.Text = "Reparation";
            this.reparationToolStripMenuItem1.Click += new System.EventHandler(this.reparationToolStripMenuItem1_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeMaterielRepareToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // listeMaterielRepareToolStripMenuItem
            // 
            this.listeMaterielRepareToolStripMenuItem.Name = "listeMaterielRepareToolStripMenuItem";
            this.listeMaterielRepareToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.listeMaterielRepareToolStripMenuItem.Text = "En Rapport Avec Client et Reaparation";
            this.listeMaterielRepareToolStripMenuItem.Click += new System.EventHandler(this.listeMaterielRepareToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 678);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donneeDeBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traitementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem listeMaterielRepareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparationToolStripMenuItem1;
    }
}

