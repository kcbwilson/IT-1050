namespace Section2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            System.Console.Write("Person 1 First Name: ");
            person1.FirstName = System.Console.ReadLine();
            System.Console.Write("Person 1 Last Name: ");
            person1.LastName = System.Console.ReadLine();
            System.Console.Write("Person 1 Age: ");
            person1.Age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Person 1 Married? (y/n): ");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                person1.Spouse = new Person();
                System.Console.Write("Spouse's Name: ");
                person1.Spouse.FirstName = System.Console.ReadLine();
                System.Console.Write("Spouse's Age: ");
                person1.Spouse.Age = int.Parse(System.Console.ReadLine());
            }

            System.Console.WriteLine(person1.Spouse.FirstName);
            System.Console.WriteLine("Press Enter");
            System.Console.ReadLine();

            //Person person2 = new Person();
            //person2.FirstName = "Temp2";
            //person2.LastName = "Temp2.2";
            //person2.age = 28;

            //Person person3 = new Person();
            //person3.FirstName = "Temp3";
            //person3.LastName = "Temp3.2";
            //person3.age = 38;
        }
    }
}
