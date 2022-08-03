using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_UNTEL_MILLETRE.core.Validation.Error
{
    public class ProcessorValidationError
    {
        public string? NameMsg { get; set; }
        public string? ReleaseDateMsg { get; set; }
        public string? PriceMsg { get; set; }
        public string? FrequencyMsg { get; set; }
        public string? ReferenceMsg { get; set; }

        public ProcessorValidationError()
        {
            NameMsg = null;
            ReleaseDateMsg = null;
            PriceMsg = null;
            FrequencyMsg = null;
            ReferenceMsg = null;
        }
    }
}
