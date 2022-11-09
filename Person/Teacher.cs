using System;

namespace A_Work_1_SchoolProj_V666
{
    class Teacher : PersonMainMenu
    {
        public void Exam()
        {
            string ans;
            Console.Write("Would you like to test the student? (Y/N): ");
            ans = Console.ReadLine();
            string answer = ans.ToLower();

            if (answer.Equals("y"))
            {
                Grading();
            }
            if (answer.Equals("n"))
            {
                Console.Write("Final teachers grades: ");
                FinalGrade();
                //Choice();
            }
        }

        public void Grading()
        {
            Student stud = new Student();
            int random   = stud.RandomNumber();

            Random rand = new Random(); // Random subject
            Type type   = typeof(Subjects);
            Array val   = type.GetEnumValues();
            int i = rand.Next(val.Length);
            Subjects value = (Subjects)val.GetValue(i);
            Console.WriteLine(value);

            switch (random)
            {
                case 2: Console.WriteLine("Grade: " + Grade.slab + ' ' + (int)Grade.slab + " - Положението е зле...");
                    Diary.grades.Add(random);
                    break;
                case 3: Console.WriteLine("Grade: " + Grade.sreden + ' ' + (int)Grade.sreden + " - Отговорът е взет от гърба на учебника..");
                    Diary.grades.Add(random);
                    break;
                case 4: Console.WriteLine("Grade: " + Grade.dobyr + ' ' + (int)Grade.dobyr + " - Задачата е непълна.");
                    Diary.grades.Add(random);
                    break;
                case 5: Console.WriteLine("Grade: " + Grade.mnogoDobyr + ' ' + (int)Grade.mnogoDobyr + " - Има грешка в решението!");
                    Diary.grades.Add(random);
                    break;
                case 6: Console.WriteLine("Grade: " + Grade.otlichen + ' ' + (int)Grade.otlichen + " - Отлично е решено всичко!!!");
                    Diary.grades.Add(random);
                    break;
            }

            Exam();
        }

        // TODO end
    }
}