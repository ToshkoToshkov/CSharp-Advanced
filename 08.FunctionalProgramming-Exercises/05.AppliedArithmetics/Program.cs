using System.Data;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<int, int> arithmetic = num => num;
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

            string cmd = Console.ReadLine();

            while (cmd != "end")
            {
                if (cmd == "add")
                {
                    arithmetic = num => num + 1;
                    numbers = numbers.Select(
                        n => arithmetic(n)).ToList();
                }
                else if (cmd == "multiply")
                {
                    arithmetic = num => num * 2;
                    numbers = numbers.Select(
                       n => arithmetic(n)).ToList();
                }
                else if (cmd == "subtract")
                {
                    arithmetic = num => num - 1;
                    numbers = numbers.Select(
                       n => arithmetic(n)).ToList();
                }
                else if (cmd == "print")
                {
                    print(numbers);
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
