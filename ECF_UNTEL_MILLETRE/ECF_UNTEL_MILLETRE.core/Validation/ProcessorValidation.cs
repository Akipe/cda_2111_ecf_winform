using ECF_UNTEL_MILLETRE.core.Validation.Error;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_UNTEL_MILLETRE.core.Validation
{
    public class ProcessorValidation
    {
        private bool _isValid;
        public readonly ProcessorValidationError Error;

        public ProcessorValidation()
        {
            Error = new ProcessorValidationError();
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

        public bool IsReleaseDateValid(string value)
        {
            if (CommonValidation.IsClassicDate(value))
            {
                return true;
            }

            Error.ReleaseDateMsg = "La date doit être au format suivant : dd/mm/YYYY (jour/mois/années)";

            _isValid = false;
            return false;
        }

        public bool IsPriceValid(string value)
        {
            if (CommonValidation.IsNumberDecimal(value, 2))
            {
                return true;
            }
                
            Error.PriceMsg = "Le prix ne peut être qu'un nombre avec au maximum 2 decimal";

            _isValid = false;
            return false;
        }

        public bool IsFrequencyValid(string value)
        {
            if (CommonValidation.IsNumberDecimal(value, 4))
            {
                return true;
            };

            Error.FrequencyMsg = "La fréquence ne peut être qu'un chiffre avec 4 décimal";
            _isValid = false;
            return false;
        }

        public bool IsReferenceValid(string value)
        {
            if (value.Length != 5)
            {
                Error.ReferenceMsg += "La référence ne peut avoir que 5 caractères (4 chiffres suivi d'une lettre).";
                _isValid = false;
                return false;
            }

            if (!Char.IsLetter(value[4]))
            {
                Error.ReferenceMsg += "Le 5éme caractère doit être une lettre.";
                _isValid = false;
                return false;
            }

            for (int indexChar = 0; indexChar < 4; indexChar++)
            {
                if (!Char.IsDigit(value[indexChar]))
                {
                    Error.ReferenceMsg += "Le 4 premiers caractères doivent être des chiffres.";
                    _isValid = false;
                    return false;
                }
            }

            return true;
        }
    }
}
