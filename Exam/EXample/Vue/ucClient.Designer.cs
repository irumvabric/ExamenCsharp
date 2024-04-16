namespace Vue
{
    partial class ucClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFemme = new System.Windows.Forms.RadioButton();
            this.radHomme = new System.Windows.Forms.RadioButton();
            this.tbxClient = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbxNationalite = new System.Windows.Forms.TextBox();
            this.Nationalite = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdClient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFemme);
            this.groupBox1.Controls.Add(this.radHomme);
            this.groupBox1.Location = new System.Drawing.Point(20, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genre";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radFemme
            // 
            this.radFemme.AutoSize = true;
            this.radFemme.Location = new System.Drawing.Point(31, 56);
            this.radFemme.Name = "radFemme";
            this.radFemme.Size = new System.Drawing.Size(59, 17);
            this.radFemme.TabIndex = 7;
            this.radFemme.TabStop = true;
            this.radFemme.Text = "Femme";
            this.radFemme.UseVisualStyleBackColor = true;
            this.radFemme.CheckedChanged += new System.EventHandler(this.radFemme_CheckedChanged);
            // 
            // radHomme
            // 
            this.radHomme.AutoSize = true;
            this.radHomme.Location = new System.Drawing.Point(31, 19);
            this.radHomme.Name = "radHomme";
            this.radHomme.Size = new System.Drawing.Size(61, 17);
            this.radHomme.TabIndex = 6;
            this.radHomme.TabStop = true;
            this.radHomme.Text = "Homme";
            this.radHomme.UseVisualStyleBackColor = true;
            this.radHomme.CheckedChanged += new System.EventHandler(this.radHomme_CheckedChanged);
            // 
            // tbxClient
            // 
            this.tbxClient.Location = new System.Drawing.Point(75, 21);
            this.tbxClient.Name = "tbxClient";
            this.tbxClient.Size = new System.Drawing.Size(145, 20);
            this.tbxClient.TabIndex = 6;
            this.tbxClient.TextChanged += new System.EventHandler(this.tbxClient_TextChanged);
            this.tbxClient.Enter += new System.EventHandler(this.tbxClient_Enter);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(75, 63);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(145, 20);
            this.tbxNom.TabIndex = 7;
            this.tbxNom.TextChanged += new System.EventHandler(this.tbxNom_TextChanged);
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.Location = new System.Drawing.Point(75, 187);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(145, 20);
            this.tbxTelephone.TabIndex = 8;
            this.tbxTelephone.TextChanged += new System.EventHandler(this.tbxTelephone_TextChanged);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(75, 226);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(145, 20);
            this.tbxEmail.TabIndex = 9;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(20, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(774, 176);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(145, 279);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(341, 279);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbxNationalite
            // 
            this.tbxNationalite.Location = new System.Drawing.Point(76, 252);
            this.tbxNationalite.Name = "tbxNationalite";
            this.tbxNationalite.Size = new System.Drawing.Size(145, 20);
            this.tbxNationalite.TabIndex = 15;
            // 
            // Nationalite
            // 
            this.Nationalite.AutoSize = true;
            this.Nationalite.Location = new System.Drawing.Point(18, 254);
            this.Nationalite.Name = "Nationalite";
            this.Nationalite.Size = new System.Drawing.Size(57, 13);
            this.Nationalite.TabIndex = 14;
            this.Nationalite.Text = "Nationalite";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(559, 279);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(450, 279);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(236, 279);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 18;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // ucClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.tbxNationalite);
            this.Controls.Add(this.Nationalite);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxTelephone);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.tbxClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucClient";
            this.Size = new System.Drawing.Size(931, 511);
            this.Load += new System.EventHandler(this.ucClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFemme;
        private System.Windows.Forms.RadioButton radHomme;
        private System.Windows.Forms.TextBox tbxClient;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbxNationalite;
        private System.Windows.Forms.Label Nationalite;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonsearch;
    }
}
