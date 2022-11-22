namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> filter = text => Char.IsUpper(text[0]);

            string input = Console.ReadLine();
            string[] words = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            words = words.Where(filter).ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}
