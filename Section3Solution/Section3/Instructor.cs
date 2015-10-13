namespace Section3
{
    class Instructor
    {
        public string Name;
        
        public string CourseName;

        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetCourse()
        {
            return this.CourseName;
        }

        public void SetStudentGrade(Student name, Student grade)
        {
            
        }

        public void Print()
        {
            System.Console.WriteLine("Teacher's name: " + this.Name);
            System.Console.WriteLine("Course Taught : " + this.CourseName);
            System.Console.WriteLine("   ");
        }
    }
}
