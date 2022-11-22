namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> partyList = new HashSet<string>();

            while (true)
            {
                string commands = Console.ReadLine();
                if (commands == "PARTY")
                {
                    break;
                }
                partyList.Add(commands);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                if (partyList.Contains(input))
                {
                    partyList.Remove(input);
                }
            }

            Console.WriteLine(partyList.Count);

            foreach (var item in partyList)
            {
                char[] ch = item.ToCharArray();
                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }

            foreach (var item in partyList)
            {
                char[] ch = item.ToCharArray();
                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
