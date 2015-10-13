namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor I1 = new Instructor("John", "English");

            Instructor I2 = new Instructor("Mike", "Math");

            Student S1 = new Student("Jane", I1);

            Student S2 = new Student("Joe", I1);

            Student S3 = new Student("Melissa", I2);

            Student S4 = new Student("Matt", I2);

            I1.SetStudentGrade(S1, 95);
            I1.SetStudentGrade(S2, 85);
            I2.SetStudentGrade(S3, 90);
            I2.SetStudentGrade(S4, 92);

            System.Console.WriteLine("    Student Information    ");
            System.Console.WriteLine(" ");
            S1.Print();
            S2.Print();
            S3.Print();
            S4.Print();
            System.Console.ReadKey();
        }
    }
}
