namespace _09.Classroom
{
    public class Classroom
    {
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        private List<Student> students;

        public int Capacity { get; set; }

        public int Count
        {
            get { return students.Count; }
        }


        public string RegisterStudent(Student student)
        {
            if (students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }

            return "No seats in the classroom";
        }

        public string DismissStudent(string firsName, string lastName)
        {
            Student student = students.FirstOrDefault(s => s.FirstName == firsName && s.LastName == lastName);

            if (student == null)
            {
                return "Student not found";
            }

            students.Remove(student);
            return $"Dismissed student {student.FirstName} {student.LastName}";
        }

        public string GetSubjectInfo(string subject)
        {
            Student student = students.FirstOrDefault(s => s.Subject == subject);

            if (student == null)
            {
                return "No students enrolled for the subject";
            }

            List<Student> subjectList = new List<Student>();


            return $"Subject: {subject}";

            Console.WriteLine("Students:");

            while (student != null)
            {
                subjectList.Add(student);
            }

            foreach (var item in subjectList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault
                (s => s.FirstName == firstName && s.LastName == lastName);

            return student;
        }
    }
}
