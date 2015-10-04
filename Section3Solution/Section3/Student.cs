namespace Section3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public void SetGrade(int grade)
        {
            this.Grade = 0;
        }
    }
}
