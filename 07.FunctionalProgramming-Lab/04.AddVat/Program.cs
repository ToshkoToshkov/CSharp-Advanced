namespace AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(n => n + (n * 0.2m))
                .ToArray();

            foreach (var item in input)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
