namespace _07.Scheduling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] input2 = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int valueOfTheTask = int.Parse(Console.ReadLine());

            Stack<int> tasks = new Stack<int>(input1);
            Queue<int> thread = new Queue<int>(input2);

            while (thread.Count != 0 && tasks.Count != 0)
            {
                if (tasks.Peek() == valueOfTheTask)
                {
                    Console.WriteLine("Thread with value {0} killed task {1}", thread.Peek(), valueOfTheTask);

                    foreach (var item in thread)
                    {
                        Console.Write(item + " ");
                    }

                    break;
                }

                if (thread.Peek() >= tasks.Peek())
                {
                    thread.Dequeue();
                    tasks.Pop();
                }
                else
                {
                    thread.Dequeue();
                }
            }
        }
    }
}



