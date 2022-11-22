namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<Decimal>> dic = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                var name = input[0];
                Decimal grade = Decimal.Parse(input[1]);

                if (!dic.ContainsKey(name))
                {
                    dic.Add(name, new List<decimal>());
                }

                dic[name].Add(grade);

            }

            foreach (var name in dic)
            {
                Console.Write($"{name.Key} -> ");

                foreach (var item in name.Value)
                {
                    Console.Write($"{item:f2} ");
                }

                Console.WriteLine($"(avg: {name.Value.Average():f2})");
            }
        }
    }
}
