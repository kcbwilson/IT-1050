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

            System.Console.WriteLine("    Teacher Information    ");
            I1.Print();
            I2.Print();

            System.Console.WriteLine("    Student Information    ");
            S1.Print();
            S2.Print();
            S3.Print();
            S4.Print();
            System.Console.ReadKey();
        }
    }
}
