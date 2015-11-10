namespace Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfChildren = 0;
            int NumberOfAdults = 0;
            int NumberOfSeniors = 0;
            int TotalAttendies = 0;

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

            double GrandTotal = 0;

            int SodaCornDiscountQty = 0;
            int FreePopcornQty = 0;
            int CandyDiscountQty = 0;

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
            System.Console.WriteLine("Ticket Price: $" + TotalTicketPrice);
            System.Console.WriteLine("Snack Price : $" + TotalFoodPrice);
            GrandTotal = TotalTicketPrice + TotalFoodPrice;
            System.Console.WriteLine("Total       : $" + GrandTotal);

            //Each purchase of a popcorn and a large soda grants a $2 discount on one movie ticket.

            if (PopCornQty > 0 && LargeSodaQty > 0)
            {
                if (PopCornQty < LargeSodaQty)
                {
                    SodaCornDiscountQty = PopCornQty;
                }

                else if (LargeSodaQty > PopCornQty)
                {
                    SodaCornDiscountQty = LargeSodaQty;
                }
                else
                {
                    SodaCornDiscountQty = LargeSodaQty;
                }
            }

            //If 3 or more people purchase tickets to an evening show, they get 1 free bag of popcorn.

            TotalAttendies = NumberOfAdults + NumberOfChildren + NumberOfSeniors;

            if (TotalAttendies >= 3)
            {
                FreePopcornQty = TotalAttendies / 3;
            }

            //For each 3 candies you buy, you can get a 4th candy for free.

            if (CandyQty >= 4)
            {
                CandyDiscountQty = CandyQty / 4;
            }

            System.Console.WriteLine("Total Discounts Earned");
            System.Console.WriteLine("$2.00 off Tickets earned     : " + SodaCornDiscountQty);
            System.Console.WriteLine("Number of Free Popcorn earned: " + FreePopcornQty);
            System.Console.WriteLine("Number of Free Candy earned  : " + CandyDiscountQty);

            GrandTotal = GrandTotal - (SodaCornDiscountQty * 2) - (FreePopcornQty * Popcorn) - (CandyDiscountQty * Candy);

            System.Console.WriteLine("Total After Discounts Applied");
            System.Console.WriteLine("Total       : $" + GrandTotal);

            System.Console.ReadKey();
        }
    }
}
