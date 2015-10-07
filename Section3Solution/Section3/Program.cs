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

            S1.Print();
            System.Console.ReadKey();
        }
    }
}
