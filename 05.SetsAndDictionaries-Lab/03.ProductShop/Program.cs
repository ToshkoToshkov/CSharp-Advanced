namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> dic = new SortedDictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            while (input != "Revision")
            {
                string[] arr = input.Split(", ");

                string shop = arr[0];
                string product = arr[1];
                double price = double.Parse(arr[2]);

                if (!dic.ContainsKey(shop))
                {
                    dic.Add(shop, new Dictionary<string, double>());
                }

                if (!dic[shop].ContainsKey(product))
                {
                    dic[shop].Add(product, price);
                }

                input = Console.ReadLine();
            }

            foreach (var shop in dic)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
