namespace Section2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        public static int TotalAge;
        public static int PersonCount;

        public static double AverageAge()
        {
            return (double)Person.TotalAge / Person.PersonCount;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine("Full Name   : " + this.GetFullName());
            System.Console.WriteLine("Age         : " + this.Age);
            if (this.Spouse.Age > 0)
            {
            System.Console.WriteLine("Married to  : " + this.Spouse.FirstName + " " + this.Spouse.LastName);
            System.Console.WriteLine("Their age is: " + this.Spouse.Age);
            }
        }

        public bool IsMarried()
        {
            return Spouse != null;
        }


        public void GetInfo()
        {
            System.Console.Write("What is your first name: ");
            FirstName = System.Console.ReadLine();
            System.Console.Write("What is your last name : ");
            LastName = System.Console.ReadLine();
            System.Console.Write("What is your age       : ");
            Age = int.Parse(System.Console.ReadLine());
            Person.PersonCount++;
            Person.TotalAge += this.Age;
        }

        public void CreateSpouseIfMarried()
        {
            System.Console.Write("Are you married? (yes/no) ");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                System.Console.WriteLine("Please Enter your spouse's information");
                this.Spouse.GetInfo();
                this.Spouse.Spouse = this;

            }
            else
            {
                this.Spouse = new Person();
                this.Spouse.Age = 0;
            }
        }


    }
}