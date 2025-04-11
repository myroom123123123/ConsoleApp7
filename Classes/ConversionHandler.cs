using System;

namespace ConsoleApp7.Classes
{
    public static class ConversionHandler
    {
        public static void HandleConversion(int fromBase, int toBase, string fromSystemName, string toSystemName)
        {
            Menu.ShowConversionHeader(fromSystemName, toSystemName);
            Console.Write($"\nВведіть {fromSystemName} число: ");
            string input = Console.ReadLine();

            try
            {
                if (fromBase == 10)
                {
                    if (int.TryParse(input, out int number))
                    {
                        string result = NumberConverter.ConvertFromDecimal(number, toBase);
                        Console.WriteLine($"\nРезультат: {result}");
                    }
                    else
                    {
                        Console.WriteLine("\nПомилка: некоректне число!");
                    }
                }
                else
                {
                    if (NumberConverter.IsValidNumber(input, fromBase))
                    {
                        int decimalNumber = NumberConverter.ConvertToDecimal(input, fromBase);
                        if (toBase == 10)
                        {
                            Console.WriteLine($"\nРезультат: {decimalNumber}");
                        }
                        else
                        {
                            string result = NumberConverter.ConvertFromDecimal(decimalNumber, toBase);
                            Console.WriteLine($"\nРезультат: {result}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nПомилка: некоректне {fromSystemName} число!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nПомилка: {ex.Message}");
            }
        }
    }
}
