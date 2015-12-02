namespace Section5
{
    public class Course
    {
        private string CourseName;
        private int CRN;
        public Student[] Students;

        public void GetCourseInfo()
        {
            CourseName = Question.AskForString("Please Enter Course Name");
            CRN = Question.AskForInteger("Please Enter CRN");
        }

        public void GetClassInfo()
        {
            int studentQty;
            studentQty = Question.AskForInteger("Please Enter Number of Students");
            Students = new Student[studentQty];
            for (int i = 0; i < studentQty; i++)
            {
                Students[i] = new Student();
                Students[i].GetStudentInfo();
            }

            System.Console.WriteLine("Course Name       : " + CourseName);
            System.Console.WriteLine("CRN               : " + CRN);
            System.Console.WriteLine("Number of Students: " + Students.Length);

            foreach (Student student in Students)
            {
                student.Print();
            }
        }
    }
}
