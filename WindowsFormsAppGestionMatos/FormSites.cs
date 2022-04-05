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
    public partial class FormSites : Form
    {
        Form opener;
        public FormSites(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void FormSites_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionMatosDataSet.SITE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sITETableAdapter.Fill(this.gestionMatosDataSet.SITE);

        }
        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            sITEBindingSource.AddNew();
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            sITEBindingSource.EndEdit();
            sITETableAdapter.Update(gestionMatosDataSet.SITE);
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            sITEBindingSource.RemoveCurrent();
        }

        private void buttonPremier_Click(object sender, EventArgs e)
        {
            sITEBindingSource.MoveFirst();
        }

        private void buttonDernier_Click(object sender, EventArgs e)
        {
            sITEBindingSource.MoveLast();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            sITEBindingSource.MoveNext();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            sITEBindingSource.MovePrevious();
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

