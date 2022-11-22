namespace _01.DefiningClasses
{
    public class Family
    {
        public Family()
        {
            this.members = new List<Person>();
        }

        public List<Person> members { get; set; }

        public void AddMember(Person person)
        {
            this.members.Add(person);
        }

        public Person GetOldestMember()
        {
            Person person = this.members
                .OrderByDescending(p => p.Age)
                .First();

            return person;
        }
    }
}
