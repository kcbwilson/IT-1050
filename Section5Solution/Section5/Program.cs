namespace Section5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string answer = "y";                       

            while (answer.ToLower().StartsWith("y"))
            {
                Course course = new Course();
                course.GetCourseInfo();
                course.GetClassInfo();                
                answer = Question.AskForString("Would you like to make any changes? y/n");                                          
            }

            System.Console.WriteLine("Press Any Key To Continue...");

            System.Console.ReadKey();

        }
    }
}
