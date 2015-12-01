namespace Section5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = Question.AskForString("Please Enter Your Name");
            student.SNumber = Question.AskForString("Please Enter Your SNumber");
            student.Print();

            Course course = new Course();
            course.CourseName = Question.AskForString("Please Enter Course Name");
            course.CRN = Question.AskForInteger("Please Enter The CRN");
            int size = Question.AskForInteger("How many students are in the class?");
            course.Students = new Student[size];
            course.Print();

            System.Console.WriteLine("Is everything correct? y/n");
            while (System.Console.ReadLine().ToLower().StartsWith("n"))
            {
                course.CourseName = Question.AskForString("Please Enter Course Name");
                course.CRN = Question.AskForInteger("Please Enter The CRN");
                int size2 = Question.AskForInteger("How many students are in the class?");
                course.Students = new Student[size2];
                course.Print();
                System.Console.WriteLine("Is everything correct? y/n");
            }

            System.Console.WriteLine("Press Any Key To Continue...");

            System.Console.ReadKey();

        }
    }
}
