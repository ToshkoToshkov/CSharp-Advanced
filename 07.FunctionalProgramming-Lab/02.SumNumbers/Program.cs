namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSumAndCount(int.Parse,
                a => a.Length,
                array => array.Sum());
        }

        static void PrintSumAndCount(Func<string, int> parser, Func<int[], int> countGetter,
          Func<int[], int> sumCalulator)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();

            Console.WriteLine(countGetter(input));
            Console.WriteLine(sumCalulator(input));
        }
    }
}
