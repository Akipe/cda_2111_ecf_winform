using ECF_UNTEL_MILLETRE.core.Model;
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
    public partial class FrmHome : Form
    {
        private ProcessorWorkUnit wu;
        private ShowProcessorViewModel vm;
        private List<string> listProcName;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void InitProc()
        {
            wu.Load();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            wu = new ProcessorWorkUnit();

            InitProc();

            listProcName = wu.GetListProcName();

            lbProcessorList.DataSource = listProcName;
        }


        private void lbProcessorList_ProcSelectChanged(object sender, EventArgs e)
        {
            vm = wu.GetInfoFromOne(lbProcessorList.SelectedItem.ToString());

            tbProcName.Text = vm.Name;
            tbProcRef.Text = vm.Reference;
            tbProcFrec.Text = vm.Frequency;
            tbProcReleaseDate.Text = vm.ReleaseDate;
            tbProcPrice.Text = vm.Price;
            tbFamilyName.Text = vm.FamilyName;
            tbFamilyArch.Text = vm.FamilyArch;
            tbFamilyId.Text = vm.FamilyId;
        }

        private void bAddProc_Click(object sender, EventArgs e)
        {
            FrmAddCpu frmAddCpu = new FrmAddCpu();
            frmAddCpu.ShowDialog();

            listProcName = wu.GetListProcName();
            lbProcessorList.DataSource = listProcName;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (wu.Save())
            {
                MessageBox.Show(
                    "Les données des processeurs ont été correctement sauvegardé.",
                    "Enregistrer terminé.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Impossible d'enregistrer le fichier."
                    + Environment.NewLine
                    + "Veuillez contacter le support informatique.",
                    "Données non sauvegardé!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
