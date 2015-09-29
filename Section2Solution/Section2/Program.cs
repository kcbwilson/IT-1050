namespace Section2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.GetInfo();
                        
            Person P2 = new Person(); ;
            P2.GetInfo();
            
            Person P3 = new Person();
            P3.GetInfo();
            
            System.Console.WriteLine("P1 Name: " + P1.GetFullName());
            System.Console.WriteLine("P1 Age: " + P1.Age);
            System.Console.WriteLine("P2 Name: " + P2.GetFullName());
            System.Console.WriteLine("P2 Age: " + P2.Age);
            System.Console.WriteLine("P3 Name: " + P3.GetFullName());
            System.Console.WriteLine("P3 Age: " + P3.Age);
            System.Console.WriteLine("Press Any Key To Continue");
            System.Console.Read();
        }
    }
}

