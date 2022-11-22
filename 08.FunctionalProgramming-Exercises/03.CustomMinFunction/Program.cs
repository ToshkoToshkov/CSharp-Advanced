namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> minNumbers = numbers =>
            {
                int minNumber = int.MaxValue;

                foreach (int num in numbers)
                {
                    if (num < minNumber)
                    {
                        minNumber = num;
                    }
                }

                return minNumber;
            };

            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int numNumber = minNumbers(list);
            Console.WriteLine(numNumber);
        }
    }
}
