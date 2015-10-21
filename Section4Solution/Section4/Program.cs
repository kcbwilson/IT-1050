namespace Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfChildren;
            int NumberOfAdults;
            int NumberOfSeniors;

            Ticket ChildMatinee = new Ticket("Child Matinee Ticket ", 3.99);
            Ticket AdultMatinee = new Ticket("Adult Matinee Ticket ", 5.99);
            Ticket SeniorMatinee = new Ticket("Senior Matinee Ticket", 4.50);

            Ticket ChildEvening = new Ticket("Child Evening Ticket ", 6.99);
            Ticket AdultEvening = new Ticket("Adult Evening Ticket ", 10.99);
            Ticket SeniorEvening = new Ticket("Senior Evening Ticket", 8.50);

            System.Console.WriteLine("Matinee Ticket Pricing");
            ChildMatinee.Print();
            AdultMatinee.Print();
            SeniorMatinee.Print();

            System.Console.WriteLine("Evening Ticket Pricing");
            ChildEvening.Print();
            AdultEvening.Print();
            SeniorEvening.Print();
            
            System.Console.WriteLine("Would you like to see a Matinee Showing?");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                System.Console.WriteLine("How many children tickets?");
                ChildMatinee.Pricing(double.Parse(System.Console.ReadLine()));
                System.Console.WriteLine("How many adult tickets?");
                AdultMatinee.Pricing(double.Parse(System.Console.ReadLine()));
                System.Console.WriteLine("How many senior tickets?");
                SeniorMatinee.Pricing(double.Parse(System.Console.ReadLine()));
            }
            else
            {
                System.Console.WriteLine("How many children tickets?");
                ChildEvening.Pricing(double.Parse(System.Console.ReadLine()));
                System.Console.WriteLine("How many adult tickets?");
                AdultEvening.Pricing(double.Parse(System.Console.ReadLine()));
                System.Console.WriteLine("How many senior tickets?");
                SeniorEvening.Pricing(double.Parse(System.Console.ReadLine()));
            }


            System.Console.ReadKey();
        }
    }
}
