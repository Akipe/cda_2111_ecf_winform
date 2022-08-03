using ECF_UNTEL_MILLETRE.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_UNTEL_MILLETRE.core.ViewModel
{
    public class AddProcessorViewModel
    {
        private string _name;
        private DateTime _releaseDate;
        private double _price;
        private double _frequency;
        private int _referenceDigit;
        private char _referenceLetter;
        private string _familyName;
        private ProcessorArch _familyArch;

        public AddProcessorViewModel()
        {

            ProcessorFamily family = new ProcessorFamily(_familyName, _familyArch);
            Processor proc = new Processor(
                family,
                _referenceDigit,
                _referenceLetter,
                _name,
                _releaseDate,
                _price,
                _frequency
            );

            ProcessorManager.List.Add(proc);
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Any(aChar => char.IsWhiteSpace(aChar)))
                {
                    throw new ArgumentException("The name can't have a space.");
                }

                _name = value;
            }
        }

        public string ReleaseDate { get; set; }

        public string Price { get; set; }

        public string Frequency { get; set; }

        public string Reference { get; set; }

        public string FamilyName
        {
            get => _name;
            set
            {
                if (value.Any(aChar => char.IsWhiteSpace(aChar)))
                {
                    throw new ArgumentException("The name can't have a space");
                }

                _name = value;
            }
        }

        public string FamilyArch
        {
            set
            {
                if (!Enum.TryParse<ProcessorArch>(value, out _familyArch))
                {
                    throw new Exception("error");
                }
            }
        }
    }
}
