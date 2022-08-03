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
        private AddProcessorViewModel vm;

        public FrmAddCpu()
        {
            InitializeComponent();
        }

        private void FrmAddCpu_Load(object sender, EventArgs e)
        {
            wu = new ProcessorWorkUnit();
            vm = new AddProcessorViewModel();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir fermer ? Toutes les données seront effacé et ne seront pas enregistrer",
                "Fermeture de la fenêtre...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            vm.Name = tbProcName.Text;
            vm.Reference = tbProcRef.Text;
            vm.Frequency = tbProcFrec.Text;
            vm.ReleaseDate = tbProcReleaseDate.Text;
            vm.Price = tbProcPrice.Text;

            vm.FamilyName = tbFamilyName.Text;
            vm.FamilyArch = tbFamilyArch.Text;

            wu.AddOne(vm);

            this.Close();
        }
    }
}
