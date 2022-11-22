namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] arr = input.ToArray();

            SortedDictionary<char, int> dic = new SortedDictionary<char, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dic.ContainsKey(arr[i]))
                {
                    dic.Add(arr[i], 0);
                }

                dic[arr[i]]++;
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
