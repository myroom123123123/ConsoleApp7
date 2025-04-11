using System;

namespace ConsoleApp7.Classes
{
    public static class UserInterface
    {
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║        ПЕРЕТВОРЕННЯ СЛІВ У ЦИФРИ     ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.WriteLine("\nВведіть слово, що представляє цифру від 0 до 9 (наприклад, 'five')");
            Console.WriteLine("Або введіть 'exit' для виходу.\n");
        }

        public static void DisplayResult(string word, int number)
        {
            Console.WriteLine($"\nРезультат: {word} → {number}\n");
        }

        public static void DisplayErrorMessage(string message)
        {
            Console.WriteLine($"\nПомилка: {message}\n");
        }
    }
}
