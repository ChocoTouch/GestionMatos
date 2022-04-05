
namespace WindowsFormsAppGestionMatos
{
    partial class FormAccueil
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
            this.labelExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonSites = new System.Windows.Forms.Button();
            this.buttonMateriel = new System.Windows.Forms.Button();
            this.buttonInterv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.Location = new System.Drawing.Point(434, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(34, 37);
            this.labelExit.TabIndex = 14;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(105, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 73);
            this.label1.TabIndex = 13;
            this.label1.Text = "Accueil";
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.Blue;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold);
            this.buttonClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClients.Location = new System.Drawing.Point(42, 398);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(372, 78);
            this.buttonClients.TabIndex = 12;
            this.buttonClients.Text = "Clients";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonSites
            // 
            this.buttonSites.BackColor = System.Drawing.Color.Blue;
            this.buttonSites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSites.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold);
            this.buttonSites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSites.Location = new System.Drawing.Point(42, 314);
            this.buttonSites.Name = "buttonSites";
            this.buttonSites.Size = new System.Drawing.Size(372, 78);
            this.buttonSites.TabIndex = 11;
            this.buttonSites.Text = "Sites";
            this.buttonSites.UseVisualStyleBackColor = false;
            this.buttonSites.Click += new System.EventHandler(this.buttonSites_Click);
            // 
            // buttonMateriel
            // 
            this.buttonMateriel.BackColor = System.Drawing.Color.Blue;
            this.buttonMateriel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMateriel.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold);
            this.buttonMateriel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonMateriel.Location = new System.Drawing.Point(42, 230);
            this.buttonMateriel.Name = "buttonMateriel";
            this.buttonMateriel.Size = new System.Drawing.Size(372, 78);
            this.buttonMateriel.TabIndex = 10;
            this.buttonMateriel.Text = "Materiel";
            this.buttonMateriel.UseVisualStyleBackColor = false;
            this.buttonMateriel.Click += new System.EventHandler(this.buttonMateriel_Click);
            // 
            // buttonInterv
            // 
            this.buttonInterv.BackColor = System.Drawing.Color.Blue;
            this.buttonInterv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInterv.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInterv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonInterv.Location = new System.Drawing.Point(42, 146);
            this.buttonInterv.Name = "buttonInterv";
            this.buttonInterv.Size = new System.Drawing.Size(372, 78);
            this.buttonInterv.TabIndex = 9;
            this.buttonInterv.Text = "Interventions";
            this.buttonInterv.UseVisualStyleBackColor = false;
            this.buttonInterv.Click += new System.EventHandler(this.buttonInterv_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(480, 531);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonSites);
            this.Controls.Add(this.buttonMateriel);
            this.Controls.Add(this.buttonInterv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAccueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonSites;
        private System.Windows.Forms.Button buttonMateriel;
        private System.Windows.Forms.Button buttonInterv;
    }
}