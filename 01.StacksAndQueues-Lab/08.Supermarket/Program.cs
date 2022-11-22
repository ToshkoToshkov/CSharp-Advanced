namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string command = Console.ReadLine();

            int count = 0;

            while (command != "End")
            {

                if (command == "Paid")
                {
                    while (names.Any())
                    {
                        Console.WriteLine(names.Dequeue());
                        count--;
                    }
                }
                else
                {
                    names.Enqueue(command);
                    count++;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} people remaining.");
        }
    }
}
