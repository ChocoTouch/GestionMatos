﻿
namespace WindowsFormsAppGestionMatos
{
    partial class FormSites
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonDernier = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonPremier = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.dataGridViewSites = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddSite = new System.Windows.Forms.TextBox();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.textBoxNomSite = new System.Windows.Forms.TextBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gestionMatosDataSet = new WindowsFormsAppGestionMatos.GestionMatosDataSet();
            this.sITEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sITETableAdapter = new WindowsFormsAppGestionMatos.GestionMatosDataSetTableAdapters.SITETableAdapter();
            this.siteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSites)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPrecedent);
            this.groupBox1.Controls.Add(this.buttonDernier);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.buttonPremier);
            this.groupBox1.Controls.Add(this.buttonSuivant);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(552, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 158);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation :";
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrecedent.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrecedent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPrecedent.Location = new System.Drawing.Point(5, 106);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(243, 23);
            this.buttonPrecedent.TabIndex = 29;
            this.buttonPrecedent.Text = "Precedent";
            this.buttonPrecedent.UseVisualStyleBackColor = false;
            // 
            // buttonDernier
            // 
            this.buttonDernier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonDernier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDernier.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDernier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDernier.Location = new System.Drawing.Point(6, 48);
            this.buttonDernier.Name = "buttonDernier";
            this.buttonDernier.Size = new System.Drawing.Size(243, 23);
            this.buttonDernier.TabIndex = 28;
            this.buttonDernier.Text = "Selectionner Dernier";
            this.buttonDernier.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(9, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 23;
            // 
            // buttonPremier
            // 
            this.buttonPremier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonPremier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPremier.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPremier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPremier.Location = new System.Drawing.Point(6, 19);
            this.buttonPremier.Name = "buttonPremier";
            this.buttonPremier.Size = new System.Drawing.Size(243, 23);
            this.buttonPremier.TabIndex = 17;
            this.buttonPremier.Text = "Selectionner Premier";
            this.buttonPremier.UseVisualStyleBackColor = false;
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuivant.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuivant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSuivant.Location = new System.Drawing.Point(6, 77);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(243, 23);
            this.buttonSuivant.TabIndex = 14;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSites
            // 
            this.dataGridViewSites.AllowUserToOrderColumns = true;
            this.dataGridViewSites.AutoGenerateColumns = false;
            this.dataGridViewSites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSites.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteIDDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
            this.dataGridViewSites.DataSource = this.sITEBindingSource;
            this.dataGridViewSites.Location = new System.Drawing.Point(40, 87);
            this.dataGridViewSites.Name = "dataGridViewSites";
            this.dataGridViewSites.Size = new System.Drawing.Size(497, 471);
            this.dataGridViewSites.TabIndex = 45;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(772, 518);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(185, 49);
            this.buttonExit.TabIndex = 43;
            this.buttonExit.Text = "Fermer";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEnregistrer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxAddSite);
            this.groupBox2.Controls.Add(this.buttonNouveau);
            this.groupBox2.Controls.Add(this.textBoxNomSite);
            this.groupBox2.Controls.Add(this.buttonSupprimer);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(552, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 196);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manager :";
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnregistrer.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEnregistrer.Location = new System.Drawing.Point(5, 138);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(393, 23);
            this.buttonEnregistrer.TabIndex = 28;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(14, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Adresse Site :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(36, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nom Site :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 23;
            // 
            // textBoxAddSite
            // 
            this.textBoxAddSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxAddSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxAddSite.Location = new System.Drawing.Point(109, 67);
            this.textBoxAddSite.Name = "textBoxAddSite";
            this.textBoxAddSite.Size = new System.Drawing.Size(290, 23);
            this.textBoxAddSite.TabIndex = 21;
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNouveau.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonNouveau.Location = new System.Drawing.Point(5, 109);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(393, 23);
            this.buttonNouveau.TabIndex = 17;
            this.buttonNouveau.Text = "Ajouter un Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = false;
            // 
            // textBoxNomSite
            // 
            this.textBoxNomSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxNomSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxNomSite.Location = new System.Drawing.Point(108, 22);
            this.textBoxNomSite.Name = "textBoxNomSite";
            this.textBoxNomSite.Size = new System.Drawing.Size(290, 23);
            this.textBoxNomSite.TabIndex = 19;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSupprimer.Location = new System.Drawing.Point(5, 167);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(393, 23);
            this.buttonSupprimer.TabIndex = 14;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(36, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Liste des Sites :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 35);
            this.label1.TabIndex = 41;
            this.label1.Text = "GESTION DES SITES";
            // 
            // gestionMatosDataSet
            // 
            this.gestionMatosDataSet.DataSetName = "GestionMatosDataSet";
            this.gestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sITEBindingSource
            // 
            this.sITEBindingSource.DataMember = "SITE";
            this.sITEBindingSource.DataSource = this.gestionMatosDataSet;
            // 
            // sITETableAdapter
            // 
            this.sITETableAdapter.ClearBeforeFill = true;
            // 
            // siteIDDataGridViewTextBoxColumn
            // 
            this.siteIDDataGridViewTextBoxColumn.DataPropertyName = "SiteID";
            this.siteIDDataGridViewTextBoxColumn.HeaderText = "SiteID";
            this.siteIDDataGridViewTextBoxColumn.Name = "siteIDDataGridViewTextBoxColumn";
            this.siteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // FormSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(972, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSites);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FormSites";
            this.Text = "Sites";
            this.Load += new System.EventHandler(this.FormSites_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSites)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonDernier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonPremier;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.DataGridView dataGridViewSites;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddSite;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.TextBox textBoxNomSite;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private GestionMatosDataSet gestionMatosDataSet;
        private System.Windows.Forms.BindingSource sITEBindingSource;
        private GestionMatosDataSetTableAdapters.SITETableAdapter sITETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
    }
}