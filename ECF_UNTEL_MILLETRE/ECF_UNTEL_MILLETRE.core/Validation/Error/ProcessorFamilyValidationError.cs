using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_UNTEL_MILLETRE.core.Validation.Error
{
    public class ProcessorFamilyValidationError
    {
        public string? NameMsg { get; set; }
        public string? ArchMsg { get; set; }

        public ProcessorFamilyValidationError()
        {
            NameMsg = null;
            ArchMsg = null;
        }
    }
}
