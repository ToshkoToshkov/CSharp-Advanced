namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>(nums);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] cmd = command.Split();
                string currcommand = cmd[0];

                if (currcommand == "add")
                {
                    numbers.Push(int.Parse(cmd[1]));
                    numbers.Push(int.Parse(cmd[2]));
                }
                else if (currcommand == "remove")
                {
                    int n = int.Parse(cmd[1]);

                    if (numbers.Count < n)
                    {
                        continue;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        numbers.Pop();
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            var sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
