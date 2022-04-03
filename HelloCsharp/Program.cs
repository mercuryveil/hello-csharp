namespace HelloCsharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto!");

            DateTime now = DateTime.Today;
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(now.ToString("MMMM"));
                now = now.AddMonths(1);

            }

            string month;

            Console.Write("Scrivi il nome del tuo mese preferito: ");

            month = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Il tuo mese preferito è {0}.", month);
            Console.WriteLine("Grazie mille, arrivederci!");
        }
    }
}