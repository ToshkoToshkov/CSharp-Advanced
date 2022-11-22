namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Queue<string> players = new Queue<string>(names);

            int n = int.Parse(Console.ReadLine());

            while (players.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    players.Enqueue(players.Dequeue());
                }
                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
