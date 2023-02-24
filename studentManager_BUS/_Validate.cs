using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace studentManager_BUS
{
    public class _Validate
    {
        public int ValidateText(string text, int min = 1, int max = 999) {
            if (text.Length >= min &&
                text.Length <= max)
            {
                return 0;
            }
            else if (text.Length < min)
            {
                return -1;
            }
            else if(text.Length > max)
            {
                return 1;
            }
            return - 1;
        }

        public int ValidateNumber(string text)
        {
            if(text.Length == 10)
            {
                Regex regex = new Regex("[0-9]");

                if (regex.IsMatch(text))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return 1;
            }
        }
    }
}
