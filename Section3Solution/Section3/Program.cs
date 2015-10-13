namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor EnglishInstructor = new Instructor("John", "English");

            Instructor MathInstructor = new Instructor("Mike", "Math");

            Student Student1 = new Student("Jane", EnglishInstructor);

            Student Student2 = new Student("Joe", EnglishInstructor);

            Student Student3 = new Student("Melissa", MathInstructor);

            Student Student4 = new Student("Matt", MathInstructor);

            EnglishInstructor.SetStudentGrade(Student1, 95);
            EnglishInstructor.SetStudentGrade(Student2, 85);
            MathInstructor.SetStudentGrade(Student3, 90);
            MathInstructor.SetStudentGrade(Student4, 92);

            System.Console.WriteLine("    Student Information    ");
            System.Console.WriteLine(" ");
            Student1.Print();
            Student2.Print();
            Student3.Print();
            Student4.Print();
            System.Console.ReadKey();
        }
    }
}
