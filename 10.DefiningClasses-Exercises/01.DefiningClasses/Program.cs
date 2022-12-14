using _01.DefiningClasses;
namespace _01.DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person currPerson = new Person(name, age);
                people.Add(currPerson);
            }

            List<Person> filteredPeople = people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            foreach (Person person in filteredPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");

            }
        }
    }
}
