namespace _04.Boombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] input2 = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> bombEffects = new Queue<int>(input1);
            Stack<int> bombCasings = new Stack<int>(input2);

            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;

            while (bombEffects.Count != 0 && bombCasings.Count != 0)
            {
                int bEfPeek = bombEffects.Peek();
                int bCaPeek = bombCasings.Peek();

                int sum = bEfPeek + bCaPeek;

                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                    break;
                }

                if (sum == 40)
                {
                    daturaBombs++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                    continue;
                }
                else if (sum == 60)
                {
                    cherryBombs++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                    continue;
                }
                else if (sum == 120)
                {
                    smokeDecoyBombs++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                    continue;
                }

                bombCasings.Pop();
                bCaPeek -= 5;
                bombCasings.Push(bCaPeek);
            }

            if (daturaBombs < 3 || cherryBombs < 3 || smokeDecoyBombs < 3)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasings.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }
    }
}
