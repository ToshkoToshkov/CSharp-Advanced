namespace CountTheSameValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> ocurrence = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!ocurrence.ContainsKey(numbers[i]))
                {
                    ocurrence.Add(numbers[i], 0);
                }

                ocurrence[numbers[i]]++;
            }

            foreach (var item in ocurrence)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
