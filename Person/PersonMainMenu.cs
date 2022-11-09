using System;

namespace A_Work_1_SchoolProj_V666
{
    class PersonMainMenu : Person
    {
        public void Choice()
        {
            Teacher teacher = new Teacher();
            Parent parent   = new Parent();
            Student student = new Student();

            string ans;
            Console.WriteLine();
            Console.WriteLine("t = teacher; p = parent; s = student; 0 = exit; f = see grades");
            Console.Write("Who will test the student? (t/p/s/f/0): ");
            ans = Console.ReadLine();
            string answer = ans.ToLower();
            Console.WriteLine();

            if (answer.Equals("t"))
            {
                teacher.Exam();
            }
            else if (answer.Equals("p"))
            {
                parent.StudentsParentExam();
            }
            else if (answer.Equals("s"))
            {
                student.RandNumOtherStudent();
            }
            else if(answer.Equals("f"))
            {
                FinalGrades();
            }
            else
            {
                Console.WriteLine("Logging you out...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public void FinalGrade()
        {
            FinalGrades();
        }

        private void FinalGrades()
        {
            Console.WriteLine();
            Console.Write("Final grades in the report card: ");
            Diary.grades.ForEach(n => Console.Write(n + ", "));
            Console.WriteLine();
            Choice();
        }

        // TODO end
    }
}