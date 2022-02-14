namespace USER_TASK
{

    class aa
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("sda", "DASDAS");
            Student stu2 = new Student("sda", "DASDAS");

            Student[] arr = { };

            Group group = new Group(33, 2, arr);

            group.AddStudent(stu1);
            group.AddStudent(stu2);
            group.GetStudents();
        }
    }
    class Student
    {
        public string Name;
        public string Surname;

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
