using System;

namespace ConsoleApp7.Classes
{
    public static class Menu
    {
        public static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║        КАЛЬКУЛЯТОР СИСТЕМ ЧИСЛЕННЯ   ║");
            Console.WriteLine("╠══════════════════════════════════════╣");
            Console.WriteLine("║ 1. Десяткова → Двійкова              ║");
            Console.WriteLine("║ 2. Двійкова → Десяткова              ║");
            Console.WriteLine("║ 3. Десяткова → Вісімкова             ║");
            Console.WriteLine("║ 4. Вісімкова → Десяткова             ║");
            Console.WriteLine("║ 5. Десяткова → Шістнадцяткова        ║");
            Console.WriteLine("║ 6. Шістнадцяткова → Десяткова        ║");
            Console.WriteLine("║ 7. Вихід                             ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.Write("\nОберіть опцію: ");
        }

        public static void ShowConversionHeader(string from, string to)
        {
            Console.Clear();
            Console.WriteLine($"╔══════════════════════════════════════╗");
            Console.WriteLine($"║ {from} → {to}".PadRight(36) + "   ║");
            Console.WriteLine($"╚══════════════════════════════════════╝");
        }
    }
}
