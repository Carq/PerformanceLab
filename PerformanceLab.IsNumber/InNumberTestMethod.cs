using System;

namespace PerformanceLab.IsNumber.NET461
{
    public static class IsNumbnerTestMethods
    {
        public static bool IntParse(string numberAsString)
        {
            try
            {
                int.Parse(numberAsString);
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        public static bool IntTryParse(string numberAsString)
        {
            int result;
            return int.TryParse(numberAsString, out result);
        }

        public static bool Custom(string numberAsString)
        {
            foreach (var c in numberAsString)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
