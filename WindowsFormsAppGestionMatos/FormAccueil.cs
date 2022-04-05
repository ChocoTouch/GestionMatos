using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGestionMatos
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void buttonInterv_Click(object sender, EventArgs e)
        {
            FormInterventions frm = new FormInterventions(this);
            frm.Show();
        }

        private void buttonMateriel_Click(object sender, EventArgs e)
        {
            FormMateriel frm = new FormMateriel(this);
            frm.Show();
        }

        private void buttonSites_Click(object sender, EventArgs e)
        {
            FormSites frm = new FormSites(this);
            frm.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            FormClient frm = new FormClient(this);
            frm.Show();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Etes-vous sûrs?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
