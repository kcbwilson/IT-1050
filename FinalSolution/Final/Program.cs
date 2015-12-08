namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevator1IsOverMaxCapacity;
            bool elevator2IsOverMaxCapacity;

            Elevator elevator1 = new Elevator(2, 400);
            Passenger A1 = new Passenger("A1", 180);            
            Passenger A2 = new Passenger("A2", 220);
            elevator1.AddOccupant(0, A1);
            elevator1.AddOccupant(1, A2);            
            elevator1.GetCurrentWeight();
            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            Elevator elevator2 = new Elevator(3, 600);
            A1 = new Passenger("A1", 200);
            A2 = new Passenger("A2", 200);
            Passenger A3 = new Passenger("A3", 201);
            elevator2.AddOccupant(0, A1);
            elevator2.AddOccupant(1, A2);
            elevator2.AddOccupant(2, A3);
            elevator2.GetCurrentWeight();
            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();

            System.Console.Read();
        }
    }
}
