using ECF_UNTEL_MILLETRE.core.Model;
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
        }

        public void AddProcessor()
        {
            
        }

        public string Name
        {
            set
            {
                if (value.Any(aChar => char.IsWhiteSpace(aChar)))
                {
                    throw new ArgumentException("The name can't have a space.");
                }

                _name = value;
            }
        }

        public string ReleaseDate
        {
            set
            {
                _releaseDate = DateTime.ParseExact(
                    value,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture
                );
                /*try
                {

                }
                catch (FormatException)
                {

                }*/
            }
        }

        public string Price
        {
            set
            {
                _price = double.Parse(value);
            }
        }

        public string Frequency
        {
            set
            {
                _frequency = double.Parse(value);
            }
        }

        public string Reference
        {
            set
            {
                if (value.Length != 5)
                {
                    throw new ArgumentException("The reference need to have a size of 5 (4 digit & 1 char)");
                }

                if (!Char.IsLetter(value[4]))
                {
                    throw new ArgumentException("The last caractere has to be a letter");
                }

                for (int indexChar = 0; indexChar < 4; indexChar++)
                {
                    if (!Char.IsDigit(value[indexChar]))
                    {
                        throw new ArgumentException("The 4 first caracteres has to be digits");
                    }
                }

                _referenceDigit = Int32.Parse(value.Substring(0, 4));
                _referenceLetter = value[4];
            }
        }

        public string FamilyName
        {
            set
            {
                if (value.Any(aChar => char.IsWhiteSpace(aChar)))
                {
                    throw new ArgumentException("The name can't have a space");
                }

                _familyName = value;
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
