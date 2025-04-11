using System;

namespace ConsoleApp7.Classes
{
    public static class NumberConverter
    {
        public static string ConvertFromDecimal(int number, int targetBase)
        {
            if (targetBase < 2 || targetBase > 16)
                throw new ArgumentException("Підтримуються лише основи від 2 до 16");

            return Convert.ToString(number, targetBase).ToUpper();
        }

        public static int ConvertToDecimal(string number, int fromBase)
        {
            if (fromBase < 2 || fromBase > 16)
                throw new ArgumentException("Підтримуються лише основи від 2 до 16");

            return Convert.ToInt32(number, fromBase);
        }

        public static bool IsValidNumber(string number, int numberBase)
        {
            try
            {
                Convert.ToInt32(number, numberBase);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
