using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem.Common
{
    public static class Validation
    {
        public static bool IsNumber(string str)
        {
            try
            {
                int.Parse(str.Trim());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool IsFloatNumber(string str)
        {
            try
            {
                float.Parse(str.Trim());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool IsEmpty(string str)
        {
            return str.Trim().Length == 0;
        }

        public static bool IsValidPhone(string str)
        {
            if (str.Trim().Length == 0)
            {
                return false;
            }
            for (int index = 0; index < str.Length; index++)
            {
                if (!char.IsDigit(str[index]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
