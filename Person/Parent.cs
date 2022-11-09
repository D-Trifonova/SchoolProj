using System;

namespace A_Work_1_SchoolProj_V666
{
    class Parent : PersonMainMenu
    {
        public void StudentsParentExam()
        {
            string quest;
            Console.Write("Would you like to ask your child a question? (Y/N): ");
            quest = Console.ReadLine();
            string question = quest.ToLower();

            if (question.Equals("y"))
            {
                Grading();
            }
            else if (question.Equals("n"))
            {
                Console.Write("See your child's report card: ");
                FinalGrade();
                //Choice();
            }
        }

        private void Grading()
        {
            PersonMainMenu person = new PersonMainMenu();
            Student stud = new Student();
            int random   = stud.RandomNumber();

            switch (random)
            {
                case 2: Console.WriteLine("Grade: " + Grade.slab + ' ' + (int)Grade.slab + "!? Без вечеря...!");
                    Diary.grades.Add(random);
                    StudentsParentExam();
                    break;
                case 3: Console.WriteLine("Grade: " + Grade.sreden + ' ' + (int)Grade.sreden + " - Поне не е две..");
                    Diary.grades.Add(random);
                    StudentsParentExam();
                    break;
                case 4: Console.WriteLine("Grade: " + Grade.dobyr + ' ' + (int)Grade.dobyr + " - Има още какво да се желае.");
                    Diary.grades.Add(random);
                    person.Choice();
                    break;
                case 5: Console.WriteLine("Grade: " + Grade.mnogoDobyr + ' ' + (int)Grade.mnogoDobyr + " - За всяка шестица - нова кола!");
                    Diary.grades.Add(random);
                    person.Choice();
                    break;
                case 6: Console.WriteLine("Grade: " + Grade.otlichen + ' ' + (int)Grade.otlichen + "!! Отлично!");
                    Diary.grades.Add(random);
                    person.Choice();
                    break;
            }
        }

        // TODO end
    }
}