namespace Section4
{
    class Ticket
    {
        private double TicketPrice;
        private string TicketType;
        private double ThisTicketPrice;

        public Ticket(string ticketType, double ticket)
        {
            this.TicketType = ticketType;
            this.TicketPrice = ticket;
        }
        
        public void Print()
        {
            System.Console.WriteLine(this.TicketType + " : $" + this.TicketPrice);
        }

        public double Pricing(double ticketQty)
        {

            this.ThisTicketPrice = this.TicketPrice * ticketQty;
            return this.ThisTicketPrice;
        }
        public double TicketTotals()
        {
            return this.ThisTicketPrice;
        }

        }
}
