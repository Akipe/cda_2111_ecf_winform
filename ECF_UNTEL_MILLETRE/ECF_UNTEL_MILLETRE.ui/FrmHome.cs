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

        private void InitSomeProc()
        {
            ProcessorManager.List.Add(new Processor(
                new ProcessorFamily("LAKE", ProcessorArch.x86),
                1200,
                'F',
                "Kakao",
                new DateTime(2018, 05, 02),
                99,
                2.7
            ));
            ProcessorManager.List.Add(new Processor(
                new ProcessorFamily("LAKE", ProcessorArch.x64),
                5600,
                'X',
                "ProLiner",
                new DateTime(2019, 09, 12),
                189,
                3.2
            ));
            ProcessorManager.List.Add(new Processor(
                new ProcessorFamily("SUMO", ProcessorArch.x64),
                8000,
                'X',
                "SayPlusPlus",
                new DateTime(2021, 11, 12),
                479,
                4.333
            ));
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            wu = new ProcessorWorkUnit();

            InitSomeProc();

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
    }
}
