namespace Section3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.SetGrade();
        }

        public void SetGrade()
        {
            this.Grade = 0;
        }

        public void Print()
        {
            System.Console.WriteLine("Student name  : " + this.Name);
            System.Console.WriteLine("Teacher's name: " + this.Teacher.Name);
            System.Console.WriteLine("Course name   : " + this.Teacher.CourseName);
            System.Console.WriteLine("Grade         : " + this.Grade);
            System.Console.WriteLine("   ");
        }
    }
}
