using ECF_UNTEL_MILLETRE.core.Model;
using ECF_UNTEL_MILLETRE.core.Validation.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_UNTEL_MILLETRE.core.Validation
{
    public class ProcessorFamilyValidation
    {
        private bool _isValid;
        public readonly ProcessorFamilyValidationError Error;

        public ProcessorFamilyValidation()
        {
            Error = new ProcessorFamilyValidationError();
            _isValid = true;
        }

        public bool IsValid()
        {
            return _isValid;
        }

        public bool IsNameValid(string value)
        {
            if (CommonValidation.HasSpace(value))
            {
                Error.NameMsg += "Le nom ne peut avoir d'espace. ";
            }
            if (!CommonValidation.IsOnlySimpleChar(value))
            {
                Error.NameMsg += "Le nom ne peut avoir que des caractère alphabetique.";
            }

            if (string.IsNullOrEmpty(Error.NameMsg))
            {
                return true;
            }

            _isValid = false;
            return false;
        }

        public bool IsArchValid(string value)
        {
            if (int.TryParse(value, out int result))
            {
                Error.ArchMsg = "L'architecture doit être soit \"x86\" ou \"x64\"";
                _isValid = false;
                return false;
            }

            ProcessorArch familyArch;

            if (Enum.TryParse<ProcessorArch>(value, out familyArch))
            {
                return true;
            }
                
            Error.ArchMsg = "L'architecture doit être soit \"x86\" ou \"x64\"";
            _isValid = false;
            return false;
        }
    }
}
