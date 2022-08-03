using ECF_UNTEL_MILLETRE.core.Model;
using ECF_UNTEL_MILLETRE.core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_UNTEL_MILLETRE.core.WorkUnit
{
    public class ProcessorWorkUnit
    {
        public void AddOne(AddProcessorViewModel viewModel)
        {
            ProcessorFamily family = new ProcessorFamily(viewModel._familyName, viewModel._familyArch);
            Processor proc = new Processor(
                family,
                viewModel._referenceDigit,
                viewModel._referenceLetter,
                viewModel._name,
                viewModel._releaseDate,
                viewModel._price,
                viewModel._frequency
            );


            ProcessorManager.List.Add(proc);
        }

        public ShowProcessorViewModel GetInfoFromOne(string procName)
        {
            ShowProcessorViewModel viewModel = new ShowProcessorViewModel();

            foreach (Processor proc in ProcessorManager.List)
            {
                if (procName == proc.Name)
                {
                    viewModel.FromOne(proc);
                }
            }

            return viewModel;
        }

        public List<string> GetListProcName()
        {
            List<string> listProcName = new List<string>();

            foreach (Processor proc in ProcessorManager.List)
            {
                listProcName.Add(proc.Name);
            }

            return listProcName;
        }
    }
}
