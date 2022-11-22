namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = input[0];
            int m = input[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n + m; i++)
            {
                int currInput = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    firstSet.Add(currInput);
                }
                else
                {
                    secondSet.Add(currInput);
                }
            }

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
