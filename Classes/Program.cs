namespace ConsoleApp7.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Menu.ShowMainMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ConversionHandler.HandleConversion(10, 2, "Десяткова", "Двійкова");
                        break;
                    case "2":
                        ConversionHandler.HandleConversion(2, 10, "Двійкова", "Десяткова");
                        break;
                    case "3":
                        ConversionHandler.HandleConversion(10, 8, "Десяткова", "Вісімкова");
                        break;
                    case "4":
                        ConversionHandler.HandleConversion(8, 10, "Вісімкова", "Десяткова");
                        break;
                    case "5":
                        ConversionHandler.HandleConversion(10, 16, "Десяткова", "Шістнадцяткова");
                        break;
                    case "6":
                        ConversionHandler.HandleConversion(16, 10, "Шістнадцяткова", "Десяткова");
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("\nНевірний вибір!");
                        break;
                }

                Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
                Console.ReadKey();
            }
        }
    }
}
