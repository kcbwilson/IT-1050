namespace Section5
{
    public class Course
    {
        private string CourseName;
        private int CRN;
        private Student[] Students;

        public void GetCourseInfo()
        {
            CourseName = Question.AskForString("Please Enter Course Name");
            CRN = Question.AskForInteger("Please Enter CRN");
        }

        public void GetClassInfo()
        {
            int size = Question.AskForInteger("Please Enter Number of Students");
            Students = new Student[size];
            for (int i = 0; i < size; i++)
            {
                Students[i] = new Student();
                Students[i].GetStudentInfo();
            }
        }
        public void PrintInfo()
        {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("        Course Information");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Course Name       : " + CourseName);
            System.Console.WriteLine("CRN               : " + CRN);
            System.Console.WriteLine("Number of Students: " + Students.Length);

            foreach (Student student in Students)
            {
                student.Print();
            }
            System.Console.WriteLine(" ");
        }
    }
}
