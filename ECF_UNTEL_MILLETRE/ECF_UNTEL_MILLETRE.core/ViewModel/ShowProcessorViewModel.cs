using ECF_UNTEL_MILLETRE.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_UNTEL_MILLETRE.core.ViewModel
{
    public class ShowProcessorViewModel
    {
        public string Name { get; private set; }

        public string ReleaseDate { get; private set; }

        public string Price { get; private set; }

        public string Frequency { get; private set; }

        public string Reference { get; private set; }

        public string FamilyName { get; private set; }

        public string FamilyArch { get; private set; }



        public ShowProcessorViewModel()
        {
        }

        

        public void FromOne(Processor proc)
        {
            Name = proc.Name;
            ReleaseDate = proc.ReleaseDate.ToShortDateString();
            Price = proc.Price.ToString("F2");
            Frequency = proc.Frequency.ToString("F4");
            Reference = proc.Reference;
            FamilyName = proc.Family.Name;
            FamilyArch = proc.Family.Arch.ToString();

            //throw new ArgumentException($"There is no processor named {name}");
        }
    }
}
