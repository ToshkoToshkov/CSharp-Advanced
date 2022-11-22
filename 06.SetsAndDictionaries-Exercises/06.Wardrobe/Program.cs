namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var inputData = Console.ReadLine().Trim().Split(" -> ");
                string color = inputData[0];


                var allClothing = inputData[1].Trim().Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (string item in allClothing)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }
                    wardrobe[color][item]++;
                }
            }

            string[] search = Console.ReadLine().Split();

            string searchedColor = search[0];
            string searchedDress = search[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var clothes in item.Value)
                {
                    if (clothes.Key == searchedDress && item.Key == searchedColor)
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }
                }
            }

        }
    }
}
