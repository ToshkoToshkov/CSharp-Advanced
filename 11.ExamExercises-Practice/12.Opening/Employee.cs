namespace _12.Opening
{
    public class Employee
    {
        public Employee(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;

            ToString();
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public override string ToString()
        {
            string result = $"Employee: {Name}, {Age} ({Country})";

            return result.ToString();
        }
    }
}
