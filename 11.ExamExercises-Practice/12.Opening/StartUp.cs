namespace _12.Opening
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Initialize the repository
            Bakery bakery = new Bakery("Barny", 10);

            //Initialize entity
            Employee employee = new Employee("Stephen", 40, "Bulgaria");

            //Print Employee
            Console.WriteLine(employee);

            //Add Employee
            bakery.Add(employee);

            //Remove Employee
            Console.WriteLine(bakery.Remove("Employee name")); //false

            Employee secondEmployee = new Employee("Mark", 34, "UK");

            //Add Employee
            bakery.Add(secondEmployee);

            Employee oldestEmployee = bakery.GetOldestEmployee();
            Employee employeeStephen = bakery.GetEmployee("Stephen");
            Console.WriteLine(oldestEmployee); 
            Console.WriteLine(employeeStephen); 

            Console.WriteLine(bakery.Count); 

            Console.WriteLine(bakery.Report());
        }
    }
}
