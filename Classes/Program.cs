namespace ConsoleApp7.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var passport1 = new ForeignPassport(
                    "AB123456",
                    "Іванов Іван Іванович",
                    new DateTime(2018, 5, 15),
                    new DateTime(2028, 5, 14),
                    "ДМСУ м. Києва");

                Console.WriteLine("Успішно створений паспорт:");
                Console.WriteLine(passport1);
                Console.WriteLine();

                try
                {
                    var passport2 = new ForeignPassport(
                        "123", 
                        "Ів", 
                        new DateTime(2030, 1, 1), 
                        new DateTime(2020, 1, 1), 
                        ""); 
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Помилка при створенні паспорта:");
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася неочікувана помилка: {ex.Message}");
            }
        }
    }
}
