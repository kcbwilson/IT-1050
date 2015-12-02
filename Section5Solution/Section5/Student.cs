namespace Section5
{
    public class Student
    {
        private string StudentName;
        private string SNumber;

        public void GetStudentInfo()
        {        
            StudentName = Question.AskForString("Please Enter Student's name");
            SNumber = Question.AskForString("Please Enter Student's SNumber");
        }

        public void Print()
        {
            System.Console.WriteLine("Student's Name    : " + StudentName);
            System.Console.WriteLine("Student's SNumber : " + SNumber);
        }
    }
}
