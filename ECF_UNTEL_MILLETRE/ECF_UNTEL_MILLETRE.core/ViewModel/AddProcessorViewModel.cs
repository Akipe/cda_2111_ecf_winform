using ECF_UNTEL_MILLETRE.core.Model;
using ECF_UNTEL_MILLETRE.core.Validation;
using ECF_UNTEL_MILLETRE.core.Validation.Error;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ECF_UNTEL_MILLETRE.core.ViewModel
{
    public class AddProcessorViewModel
    {
        private ProcessorValidation _procValidator;
        private ProcessorFamilyValidation _familyValidator;

        public string _name;
        public DateTime _releaseDate;
        public double _price;
        public double _frequency;
        public int _referenceDigit;
        public char _referenceLetter;
        public string _familyName;
        public ProcessorArch _familyArch;

        public AddProcessorViewModel()
        {
            _procValidator = new ProcessorValidation();
            _familyValidator = new ProcessorFamilyValidation();
        }

        public bool IsValid()
        {
            return 
                _procValidator.IsValid() &&
                _familyValidator.IsValid()
            ;
        }

        public ProcessorFamilyValidationError GetProcFamilyErrors()
        {
            return _familyValidator.Error;
        }

        public ProcessorValidationError GetProcErrors()
        {
            return _procValidator.Error;
        }

        public string Name
        {
            set
            {
                if (_procValidator.IsNameValid(value))
                {
                    _name = value;
                }
            }
        }

        public string ReleaseDate
        {
            set
            {
                if (_procValidator.IsReleaseDateValid(value))
                {
                    _releaseDate = DateTime.ParseExact(
                        value,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture
                    );
                }
            }
        }

        public string Price
        {
            set
            {
                if (_procValidator.IsPriceValid(value))
                {
                    value = value.Replace(".", ",");

                    _price = double.Parse(value);
                }
            }
        }

        public string Frequency
        {
            set
            {
                if (_procValidator.IsFrequencyValid(value))
                {
                    value = value.Replace(".", ",");

                    _frequency = double.Parse(value);
                }
            }
        }

        public string Reference
        {
            set
            {
                if (_procValidator.IsReferenceValid(value))
                {
                    _referenceDigit = Int32.Parse(value.Substring(0, 4));
                    _referenceLetter = value[4];
                }
            }
        }

        public string FamilyName
        {
            set
            {
                if (_familyValidator.IsNameValid(value))
                {
                    _familyName = value;
                }
            }
        }

        public string FamilyArch
        {
            set
            {
                if (_familyValidator.IsArchValid(value))
                {
                    _familyArch = Enum.Parse<ProcessorArch>(value);
                }
            }
        }
    }
}
