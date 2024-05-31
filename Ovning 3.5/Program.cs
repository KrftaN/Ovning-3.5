namespace övning_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren ange två tal
            Console.WriteLine("Ange det första talet:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange det andra talet:");
            double num2 = double.Parse(Console.ReadLine());

            // Skriv ut menyn
            Console.WriteLine("Välj ett räknesätt:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            // Be användaren att välja ett räknesätt
            int choice = int.Parse(Console.ReadLine());

            // Utför den valda beräkningen och skriv ut resultatet
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Resultatet av additionen är: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultatet av subtraktionen är: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultatet av multiplikationen är: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Resultatet av divisionen är: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Fel: Division med noll är inte tillåten.");
                    }
                    break;
                default:
                    Console.WriteLine("Fel: Ogiltigt val.");
                    break;
            }
        }
    }
}
