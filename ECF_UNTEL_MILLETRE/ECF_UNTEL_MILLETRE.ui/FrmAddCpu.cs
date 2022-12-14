using ECF_UNTEL_MILLETRE.core.Validation.Error;
using ECF_UNTEL_MILLETRE.core.ViewModel;
using ECF_UNTEL_MILLETRE.core.WorkUnit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECF_UNTEL_MILLETRE.ui
{
    public partial class FrmAddCpu : Form
    {
        private ProcessorWorkUnit wu;
        private bool hasSaved;

        public FrmAddCpu()
        {
            InitializeComponent();
        }

        private void FrmAddCpu_Load(object sender, EventArgs e)
        {
            wu = new ProcessorWorkUnit();
            hasSaved = false;

            tbProcReleaseDate.Text = DateTime.Now.ToShortDateString();
            cbFamilyArch.SelectedIndex = 0;

            this.AcceptButton = bAdd;
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AddProcessorViewModel vm = new AddProcessorViewModel();

            vm.Name = tbProcName.Text;
            vm.Reference = tbProcRef.Text;
            vm.Frequency = tbProcFrec.Text;
            vm.ReleaseDate = tbProcReleaseDate.Text;
            vm.Price = tbProcPrice.Text;

            vm.FamilyName = tbFamilyName.Text;
            vm.FamilyArch = cbFamilyArch.SelectedItem.ToString();

            if (vm.IsValid())
            {
                wu.AddOne(vm);
                hasSaved = true;
                Close();
            }
            else
            {
                ProcessorValidationError procErr = vm.GetProcErrors();
                ProcessorFamilyValidationError famErr = vm.GetProcFamilyErrors();

                lProcNameMsg.Text = procErr.NameMsg;
                lProcRefMsg.Text = procErr.ReferenceMsg;
                lProcFrecMsg.Text = procErr.FrequencyMsg;
                lProcReleaseDateMsg.Text = procErr.ReleaseDateMsg;
                lProcPriceMsg.Text = procErr.PriceMsg;
                lFamNameMsg.Text = famErr.NameMsg;
                lFamArchMsg.Text = famErr.ArchMsg;

                MessageBox.Show(
                    "Certains champs sont incorrectes, veuillez les corriger",
                    "Erreur lors de l'enregistrement",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void FrmAddCpu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasSaved)
            {
                MessageBox.Show(
                    "Processeur enregistré",
                    "Sauvegarde terminé",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir fermer ? Toutes les données seront effacé et ne seront pas enregistrer",
                    "Fermeture de la fenêtre...",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
