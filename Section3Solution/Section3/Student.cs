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
            this.Grade = 0;
        }

        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }

        public void Print()
        {
            System.Console.WriteLine("Student name  : " + this.Name);
            this.Teacher.Print();
            System.Console.WriteLine("Grade         : " + this.Grade);
            System.Console.WriteLine("   ");
        }
    }
}
