namespace Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfChildren;
            int NumberOfAdults;
            int NumberOfSeniors;

            double TotalTicketPrice = 0;

            int SmallSodaQty;
            int LargeSodaQty;
            int HotDogQty;
            int PopCornQty;
            int CandyQty;

            double TotalFoodPrice = 0;

            const double SmallSoda = 3.50;
            const double LargeSoda = 5.99;
            const double HotDog = 3.99;
            const double Popcorn = 4.50;
            const double Candy = 1.99;

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
                NumberOfChildren = int.Parse(System.Console.ReadLine());
                ChildMatinee.Pricing(NumberOfChildren);
                TotalTicketPrice += ChildMatinee.TicketTotals();

                System.Console.WriteLine("How many adult tickets?");
                NumberOfAdults = int.Parse(System.Console.ReadLine());
                AdultMatinee.Pricing(NumberOfAdults);
                TotalTicketPrice += AdultMatinee.TicketTotals();

                System.Console.WriteLine("How many senior tickets?");
                NumberOfSeniors = int.Parse(System.Console.ReadLine());
                SeniorMatinee.Pricing(NumberOfSeniors);
                TotalTicketPrice += SeniorMatinee.TicketTotals();
            }
            else
            {
                System.Console.WriteLine("How many children tickets?");
                NumberOfChildren = int.Parse(System.Console.ReadLine());
                ChildEvening.Pricing(NumberOfChildren);
                TotalTicketPrice += ChildEvening.TicketTotals();

                System.Console.WriteLine("How many adult tickets?");
                NumberOfAdults = int.Parse(System.Console.ReadLine());
                AdultEvening.Pricing(NumberOfAdults);
                TotalTicketPrice += AdultEvening.TicketTotals();

                System.Console.WriteLine("How many senior tickets?");
                NumberOfSeniors = int.Parse(System.Console.ReadLine());
                SeniorEvening.Pricing(NumberOfSeniors);
                TotalTicketPrice += SeniorEvening.TicketTotals();
            }

            System.Console.WriteLine("Please indicate how many of each item you would like");
            
            System.Console.Write("Small Soda $" + SmallSoda + ": ");
            SmallSodaQty = int.Parse(System.Console.ReadLine());
            TotalFoodPrice += (SmallSodaQty * SmallSoda);

            System.Console.Write("Large Soda $" + LargeSoda + ": ");
            LargeSodaQty = int.Parse(System.Console.ReadLine());
            TotalFoodPrice += (LargeSodaQty * LargeSoda);

            System.Console.Write("Hot Dog    $" + HotDog + ": ");
            HotDogQty = int.Parse(System.Console.ReadLine());
            TotalFoodPrice += (HotDogQty * HotDog);

            System.Console.Write("Popcorn    $" + Popcorn + ": ");
            PopCornQty = int.Parse(System.Console.ReadLine());
            TotalFoodPrice += (PopCornQty * Popcorn);

            System.Console.Write("Candy      $" + Candy + ": ");
            CandyQty = int.Parse(System.Console.ReadLine());
            TotalFoodPrice += (CandyQty * Candy);

            System.Console.WriteLine("Totals before discounts applied");
            System.Console.WriteLine("Ticket Total: $" + TotalTicketPrice);
            System.Console.WriteLine("Snack Total : $" + TotalFoodPrice);

            System.Console.ReadKey();
        }
    }
}
