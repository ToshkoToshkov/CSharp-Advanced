namespace _01.FlowerWreaths
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

            Queue<int> roses = new Queue<int>(input2);
            Stack<int> lilies = new Stack<int>(input1);

            int countWreaths = 0;
            int storedSum = 0;

            for (int i = 0; i < lilies.Count + 1; i++)
            {
                for (int j = 0; j < roses.Count + 1; j++)
                {
                    int liliesPeek = lilies.Peek();
                    int rosesPeek = roses.Peek();
                    int sum = liliesPeek + rosesPeek;

                    if (sum == 15)
                    {
                        lilies.Pop();
                        roses.Dequeue();
                        countWreaths++;
                    }
                    else if (sum > 15)
                    {
                        while (sum > 15)
                        {
                            liliesPeek -= 2;
                            sum = liliesPeek + rosesPeek;

                            if (sum < 15)
                            {
                                storedSum += sum;
                                continue;
                            }
                            else if (sum == 15)
                            {
                                countWreaths++;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        lilies.Pop();
                        roses.Dequeue();

                    }
                    else if (sum < 15)
                    {
                        storedSum += sum;

                        lilies.Pop();
                        roses.Dequeue();
                    }
                }
            }

            while (storedSum >= 15)
            {
                countWreaths++;
                storedSum -= 15;
            }

            if (countWreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {countWreaths} wreaths!");
            }
            else
            {
                int dif = 5 - countWreaths;

                Console.WriteLine($"You didn't make it, you need {dif} wreaths more!");
            }
        }
    }
}
