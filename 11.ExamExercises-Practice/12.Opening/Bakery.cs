using System.Text;

namespace _12.Opening
{
    public class Bakery
    {
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Employee>();
        }

        private List<Employee> data;

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        public void Add(Employee employee)
        {
            if (data.Count < Capacity)
            {
                data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee employee = data.FirstOrDefault(e => e.Name == name);

            if (employee == null)
            {
                return false;
            }

            data.Remove(employee);
            return true;
        }

        public Employee GetOldestEmployee()
        {
            return data.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = data.FirstOrDefault(e => e.Name == name);
            return employee;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Employees working at Bakery {Name}:");

            foreach (Employee item in data)
            {
                result.AppendLine($"Employee: {item.Name}, {item.Age} ({item.Country})");
            }

            return result.ToString();
        }
    }
}
