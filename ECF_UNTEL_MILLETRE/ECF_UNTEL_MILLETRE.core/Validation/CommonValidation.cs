using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ECF_UNTEL_MILLETRE.core.Validation
{
    public class CommonValidation
    {
        public static bool HasSpace(string value)
        {
            if (value.Any(aChar => char.IsWhiteSpace(aChar)))
            {
                return true;
            }

            return false;
        }

        public static bool IsOnlySimpleChar(string value)
        {
            Regex rule = new Regex(@"^[a-zA-Z]+$");

            return rule.IsMatch(value);
        }

        public static bool IsClassicDate(string value)
        {
            try
            {
                DateTime.ParseExact(
                    value,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture
                );

                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool IsNumberDecimal(string value, int numberDec)
        {
            Regex rule = new Regex($"^[\\d]{{1,}}([,.]{{1}}[\\d]{{1,{numberDec}}})?$");

            return rule.IsMatch(value);
        }
    }
}
