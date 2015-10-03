namespace Section2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.GetInfo();
            P1.CreateSpouseIfMarried();

            Person P2 = new Person();
            P2.GetInfo();
            P2.CreateSpouseIfMarried();

            Person P3 = new Person();
            P3.GetInfo();
            P3.CreateSpouseIfMarried();

            P1.PrintNameAndAge();
            P1.Spouse.PrintNameAndAge();
            P2.PrintNameAndAge();
            P2.Spouse.PrintNameAndAge();
            P3.PrintNameAndAge();
            P3.Spouse.PrintNameAndAge();


            System.Console.WriteLine("The average age is " + Person.AverageAge());
            System.Console.ReadKey();
        }
    }
}

