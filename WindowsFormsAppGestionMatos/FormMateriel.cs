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
    public partial class FormMateriel : Form
    {
        Form opener;
        public FormMateriel(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void gestionMatosDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormMateriel_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionMatosDataSet.MATERIEL'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mATERIELTableAdapter.Fill(this.gestionMatosDataSet.MATERIEL);

        }
        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            mATERIELBindingSource.AddNew();
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            mATERIELBindingSource.EndEdit();
            mATERIELTableAdapter.Update(gestionMatosDataSet.MATERIEL);
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            mATERIELBindingSource.RemoveCurrent();
        }

        private void buttonPremier_Click(object sender, EventArgs e)
        {
            mATERIELBindingSource.MoveFirst();
        }

        private void buttonDernier_Click(object sender, EventArgs e)
        {
            mATERIELBindingSource.MoveLast();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            mATERIELBindingSource.MoveNext();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            mATERIELBindingSource.MovePrevious();
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
