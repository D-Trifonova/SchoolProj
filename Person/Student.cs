using System;
using System.Collections.Generic;

namespace A_Work_1_SchoolProj_V666
{
    class Student : PersonMainMenu
    {
        public int RandNumOtherStudent()
        {
            PersonMainMenu person = new PersonMainMenu();

            int random = RandomNumber();

            Console.WriteLine("Grade: " + RandomNumber());

            if (random >= 4)
            {
                Console.WriteLine("Thanks for the help! :)");
                Diary.grades.Add(random);
                person.Choice();
            }
            else if (random <= 3)
            {
                Console.WriteLine("Thanks for nothing! >:(");
                Diary.grades.Add(random);
                person.Choice();
            }

            return RandomNumber();
        }

        public int RandomNumber()
        {
            Random randNum = new Random();
            int number     = randNum.Next(2, 7);
            
            return number;
        }

        // TODO end
    }
}