namespace Final
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }

        public void AddOccupant(int index, Passenger passenger)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double totalWeight = 0;

            foreach (Passenger passenger in Occupants)
            {
                totalWeight += passenger.GetWeight();
            }

            return totalWeight;
        }

        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() <= MaxWeight)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
