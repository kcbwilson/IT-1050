namespace Section3
{
    class Instructor
    {
        private string Name;
        
        private string CourseName;

        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public void Print()
        {
            System.Console.WriteLine("Teacher's name: " + this.Name);
            System.Console.WriteLine("Course Taught : " + this.CourseName);
        }
    }
}
