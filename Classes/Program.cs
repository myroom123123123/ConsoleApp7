namespace ConsoleApp7.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Логічний калькулятор");
            Console.WriteLine("Введіть вираз (наприклад, 3>2 або 7<=3)");
            Console.WriteLine("Доступні оператори: <, >, <=, >=, ==, !=");
            Console.WriteLine("Для виходу введіть 'exit'");

            while (true)
            {
                Console.Write("\nВведіть вираз: ");
                string input = Console.ReadLine()?.Trim();

                if (input?.ToLower() == "exit")
                    break;

                try
                {
                    bool result = LogicalExpressionCalculator.Evaluate(input);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            }
        }
    }
}
