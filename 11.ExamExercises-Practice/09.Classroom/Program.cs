namespace _09.Classroom
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository
            Classroom classroom = new Classroom(10);

            // Initialize entities
            Student student = new Student("Peter", "Parker", "Geometry");
            Student studentTwo = new Student("Sarah", "Smith", "Algebra");
            Student studentThree = new Student("Sam", "Winchester", "Algebra");
            Student studentFour = new Student("Dean", "Winchester", "Music");

            // Print Student
            Console.WriteLine(student);
                                        
            // Register Student
            string register = classroom.RegisterStudent(student);
            Console.WriteLine(register);

            string registerTwo = classroom.RegisterStudent(studentTwo);
            string registerThree = classroom.RegisterStudent(studentThree);
            string registerFour = classroom.RegisterStudent(studentFour);

            // Dismiss Student
            string dismissed = classroom.DismissStudent("Peter", "Parker");
            Console.WriteLine(dismissed); 
            string dismissedTwo = classroom.DismissStudent("Ellie", "Goulding");
            Console.WriteLine(dismissedTwo);
            
            // Subject info
            string subjectInfo = classroom.GetSubjectInfo("Algebra");
            Console.WriteLine(subjectInfo);

            string anotherInfo = classroom.GetSubjectInfo("Art");
            Console.WriteLine(anotherInfo);
                                            
            // Get Student
            Console.WriteLine(classroom.GetStudent("Dean", "Winchester"));
        }
    }
}
