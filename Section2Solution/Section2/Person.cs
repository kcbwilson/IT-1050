namespace Section2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public string SpouseFirstName;
        public string SpouseLastName;
        public int SpouseAge;
        int TotalAge = 0;
        int PersonCount = 0;
        int AverageAge = 0;

        public bool IsMarried()
        {
            return Spouse != null;
        }


        public void GetInfo()
        {
            System.Console.Write("What is your first name: ");
            FirstName = System.Console.ReadLine();
            System.Console.Write("What is your last name: ");
            LastName = System.Console.ReadLine();
            System.Console.Write("What is your age: ");
            Age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Are you married? (yes/no) ");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                Spouse = new Person();
                System.Console.WriteLine("What is your spouse's first name? ");
                Spouse.SpouseFirstName = System.Console.ReadLine();
                System.Console.WriteLine("What is your spouse's last name? ");
                Spouse.SpouseLastName = System.Console.ReadLine();
                System.Console.WriteLine("What is your spouse's age? ");
                Spouse.SpouseAge = int.Parse(System.Console.ReadLine());
            }
         }


        public string GetFullName()
        {
            string FullName = "";
            FullName += this.FirstName;
            FullName += " ";
            FullName += this.LastName;
            return FullName;
        }


        public string GetSpouseFullName()
        {
            string SpouseFullName = " ";
            SpouseFullName += this.SpouseFirstName;
            SpouseFullName += " ";
            SpouseFullName += this.SpouseLastName;
            return SpouseFullName;
        }
        public void CalcAge()
        {
            AverageAge = TotalAge / PersonCount;
        }


        public void FullSpouseNameAndAge()
        {
            System.Console.WriteLine("My Spouse's name is " + this.GetSpouseFullName());
            System.Console.WriteLine("My Spouse's age is " + this.SpouseAge);
        }


    }
}