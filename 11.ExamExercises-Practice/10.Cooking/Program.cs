namespace _10.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] input2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquids = new Queue<int>(input1);
            Stack<int> ingredients = new Stack<int>(input2);

            int bread = 0;
            int cake = 0;
            int pastry = 0;
            int fruitPie = 0;

            while (liquids.Count != 0 && ingredients.Count != 0)
            {
                int ingredientsPeek = ingredients.Peek();

                int sum = liquids.Peek() + ingredientsPeek;

                if (sum == 25)
                {
                    bread++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    continue;
                }
                else if (sum == 50)
                {
                    cake++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    continue;
                }
                else if (sum == 75)
                {
                    pastry++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    continue;
                }
                else if (sum == 100)
                {
                    fruitPie++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    continue;
                }

                liquids.Dequeue();
                ingredients.Pop();
                ingredientsPeek += 3;
                ingredients.Push(ingredientsPeek);
            }

            if (liquids.Count == 0 && ingredients.Count == 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }

            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }

            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");
        }
    }
}
