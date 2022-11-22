namespace FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int start = ranges[0];
            int end = ranges[1];

            Func<int, int, List<int>> generateRangOfNums = (s, e) =>
            {
                List<int> nums = new List<int>();

                for (int i = s; i <= e; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };

            List<int> numbers = generateRangOfNums(start, end);

            string command = Console.ReadLine();

            if (command == "even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            else if (command == "odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }

        }
    }
}
