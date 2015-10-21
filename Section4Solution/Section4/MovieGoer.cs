namespace Section4
{
    class MovieGoer
    {
        private static double ChildMatineeTicket = 3.99;
        private static double AdultMatineeTicket = 5.99;
        private static double SeniorMatineeTicket = 4.50;

        private static double ChildEveningTicket = 6.99;
        private static double AdultEveningTicket = 10.99;
        private static double SeniorEveningTicket = 8.50;

        private static double SmallSoda = 3.50;
        private static double LargeSoda = 5.99;
        private static double HotDog = 3.99;
        private static double Popcorn = 4.50;
        private static double Candy = 1.99;

        public void Matinee()
        {
            System.Console.WriteLine("Matinee Ticket Pricing");
            System.Console.WriteLine("Child Ticket : $" + ChildMatineeTicket);
            System.Console.WriteLine("Adult Ticket : $" + AdultMatineeTicket);
            System.Console.WriteLine("Senior Ticket: $" + SeniorMatineeTicket);
        }

        

        
    }
}
