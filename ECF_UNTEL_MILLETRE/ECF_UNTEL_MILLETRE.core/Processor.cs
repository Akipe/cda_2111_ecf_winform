using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECF_UNTEL_MILLETRE.core
{
    public class Processor
    {
        private string _name;
        private DateTime? _releaseDate;

        public Processor(
            ProcessorFamily family,
            int referenceDigit,
            char referenceLetter,
            string name,
            DateTime? releaseDate,
            double price,
            double frequency
        ) {
            Family = family;
            SetReference(referenceDigit, referenceLetter);
            Name = name;
            ReleaseDate = releaseDate;
            Price = price;
            Frequency = frequency;
        }

        public ProcessorFamily Family { get; private set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Any(aChar => Char.IsWhiteSpace(aChar)))
                {
                    throw new ArgumentException("The name can't have a space.");
                }

                _name = value;
            }
        }

        public DateTime? ReleaseDate
        {
            get
            {
                return _releaseDate;
            }

            set
            {
                if (_releaseDate is null)
                {
                    _releaseDate = value;
                }
            }
        }

        public double Price { get; set; }

        public double? Frequency { get; private set; }

        public string? Reference { get; private set; }

        private void SetReference(int firstDigit, char lastLetter)
        {
            Reference = firstDigit.ToString() + lastLetter.ToString();
        }
    }
}