namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ").ToList();

            List<string> newNames = names.Select(n => $"Sir {n}").ToList();

            Action<List<string>> printNames = n => Console.WriteLine(string.Join(Environment.NewLine, n));

            printNames(newNames);
        }
    }
}
