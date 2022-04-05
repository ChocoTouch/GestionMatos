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
    public partial class FormInterventions : Form
    {
        Form opener;
        public FormInterventions(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void FormInterventions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionMatosDataSet.Interventions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.interventionsTableAdapter.Fill(this.gestionMatosDataSet.Interventions);

        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            interventionsBindingSource.AddNew();
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            interventionsBindingSource.EndEdit();
            interventionsTableAdapter.Update(gestionMatosDataSet.Interventions);
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            interventionsBindingSource.RemoveCurrent();
        }

        private void buttonPremier_Click(object sender, EventArgs e)
        {
            interventionsBindingSource.MoveFirst();
        }

        private void buttonDernier_Click(object sender, EventArgs e)
        {
            interventionsBindingSource.MoveLast();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            interventionsBindingSource.MoveNext();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            interventionsBindingSource.MovePrevious();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Etes-vous sûrs?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
