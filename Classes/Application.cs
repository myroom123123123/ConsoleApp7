using System;

namespace ConsoleApp7.Classes
{
    public static class Application
    {
        public static void Run()
        {
            UserInterface.DisplayWelcomeMessage();

            while (true)
            {
                Console.Write("Введіть слово: ");
                string input = Console.ReadLine()?.Trim();

                if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    if (WordToNumberConverter.IsValidWord(input))
                    {
                        int number = WordToNumberConverter.Convert(input);
                        UserInterface.DisplayResult(input, number);
                    }
                    else
                    {
                        UserInterface.DisplayErrorMessage("Невірне введення. Спробуйте ще раз.");
                    }
                }
                catch (Exception ex)
                {
                    UserInterface.DisplayErrorMessage(ex.Message);
                }
            }
        }
    }
}
