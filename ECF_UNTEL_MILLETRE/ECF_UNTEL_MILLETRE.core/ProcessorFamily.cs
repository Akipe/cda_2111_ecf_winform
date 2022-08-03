using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECF_UNTEL_MILLETRE.core
{
    public class ProcessorFamily
    {
        private int _id;
        private string _name;

        public int Id
        {
            get => _id;
            set
            {
                if (_id <= 1000)
                {
                    throw new ArgumentException("The id has to be superior to 1000");
                }

                _id = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Any(aChar => Char.IsWhiteSpace(aChar)))
                {
                    throw new ArgumentException("The name can't have a space");
                }

                _name = value;
            }
        }

        public ProcessorArch Arch { get; set; }
    }
}