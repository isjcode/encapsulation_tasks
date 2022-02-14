namespace USER_TASK
{
    class Group
    {
        public int No;
        public int Limit;
        private Student[] Students;

        public Group(int a_no, int a_limit, Student [] arr)
        {
            No = a_no;
            Limit = a_limit;
            Students = arr;

        }

        public void AddStudent(Student student)
        {
            if (Limit > Students.Length)
            {
;
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length-1] = student;
  
            }
            else
            {
             
                Console.WriteLine("Qrup Dolub.");
                return;
            }
        }

        public void GetStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student.Name + " " + student.Surname);

            }
        }
    }
}
