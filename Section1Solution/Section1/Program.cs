namespace Section1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            System.Console.Write("Enter you first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter you middle initial: ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("Enter you last name: ");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + ". " + lastName;

            System.Console.Write("Enter your height in feet (EX: if 6ft 3.25in tall, please just type 6): ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter remaining inches (EX: if 6ft 3in tall, please enter 3.25): ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            System.Console.Write("Enter age: ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen? (please enter true or false) ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            canVote = isCitizen && age >= 18;

            System.Console.WriteLine("Full name: " + fullName);
            System.Console.WriteLine("Height in CM: " + totalHeightCM);
            System.Console.WriteLine("Can Vote: " + canVote);

            System.Console.ReadLine();
        }
    }
}
