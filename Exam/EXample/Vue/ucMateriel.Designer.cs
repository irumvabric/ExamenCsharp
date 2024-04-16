namespace Vue
{
    partial class ucMateriel
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ptbMateriel = new System.Windows.Forms.PictureBox();
            this.btnImporte = new System.Windows.Forms.Button();
            this.tbxIdmateriel = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxSerie = new System.Windows.Forms.TextBox();
            this.rtbCommentaire = new System.Windows.Forms.RichTextBox();
            this.tbxMarque = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdMateriel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Photo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "commentaire";
            // 
            // ptbMateriel
            // 
            this.ptbMateriel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbMateriel.Location = new System.Drawing.Point(556, 42);
            this.ptbMateriel.Name = "ptbMateriel";
            this.ptbMateriel.Size = new System.Drawing.Size(226, 171);
            this.ptbMateriel.TabIndex = 6;
            this.ptbMateriel.TabStop = false;
            this.ptbMateriel.Click += new System.EventHandler(this.ptbMateriel_Click);
            // 
            // btnImporte
            // 
            this.btnImporte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImporte.Location = new System.Drawing.Point(556, 229);
            this.btnImporte.Name = "btnImporte";
            this.btnImporte.Size = new System.Drawing.Size(110, 23);
            this.btnImporte.TabIndex = 7;
            this.btnImporte.Text = "Importe";
            this.btnImporte.UseVisualStyleBackColor = false;
            this.btnImporte.Click += new System.EventHandler(this.btnImporte_Click);
            // 
            // tbxIdmateriel
            // 
            this.tbxIdmateriel.Location = new System.Drawing.Point(167, 39);
            this.tbxIdmateriel.Name = "tbxIdmateriel";
            this.tbxIdmateriel.Size = new System.Drawing.Size(146, 20);
            this.tbxIdmateriel.TabIndex = 8;
            this.tbxIdmateriel.TextChanged += new System.EventHandler(this.tbxIdmateriel_TextChanged);
            this.tbxIdmateriel.Enter += new System.EventHandler(this.tbxIdmateriel_Enter);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(167, 85);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(146, 20);
            this.tbxNom.TabIndex = 9;
            this.tbxNom.TextChanged += new System.EventHandler(this.tbxNom_TextChanged);
            // 
            // tbxSerie
            // 
            this.tbxSerie.Location = new System.Drawing.Point(167, 137);
            this.tbxSerie.Name = "tbxSerie";
            this.tbxSerie.Size = new System.Drawing.Size(146, 20);
            this.tbxSerie.TabIndex = 10;
            this.tbxSerie.TextChanged += new System.EventHandler(this.tbxSerie_TextChanged);
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.Location = new System.Drawing.Point(167, 248);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(200, 57);
            this.rtbCommentaire.TabIndex = 11;
            this.rtbCommentaire.Text = "";
            this.rtbCommentaire.TextChanged += new System.EventHandler(this.rtbCommentaire_TextChanged);
            // 
            // tbxMarque
            // 
            this.tbxMarque.Location = new System.Drawing.Point(167, 179);
            this.tbxMarque.Name = "tbxMarque";
            this.tbxMarque.Size = new System.Drawing.Size(146, 20);
            this.tbxMarque.TabIndex = 12;
            this.tbxMarque.TextChanged += new System.EventHandler(this.tbxMarque_TextChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(105, 329);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Save";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(366, 329);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(513, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(628, 329);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Clients";
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(167, 213);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClients.TabIndex = 21;
            this.comboBoxClients.SelectedIndexChanged += new System.EventHandler(this.comboBoxClients_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(70, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(774, 176);
            this.dataGridView1.TabIndex = 22;
            // 
            // ucMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbxMarque);
            this.Controls.Add(this.rtbCommentaire);
            this.Controls.Add(this.tbxSerie);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.tbxIdmateriel);
            this.Controls.Add(this.btnImporte);
            this.Controls.Add(this.ptbMateriel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucMateriel";
            this.Size = new System.Drawing.Size(929, 559);
            this.Load += new System.EventHandler(this.ucMateriel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ptbMateriel;
        private System.Windows.Forms.Button btnImporte;
        private System.Windows.Forms.TextBox tbxIdmateriel;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxSerie;
        private System.Windows.Forms.RichTextBox rtbCommentaire;
        private System.Windows.Forms.TextBox tbxMarque;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
