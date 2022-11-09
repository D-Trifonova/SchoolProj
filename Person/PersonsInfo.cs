using System;

namespace A_Work_1_SchoolProj_V666
{
    class PersonsInfo : Person
    {
        public void Info()
        {
            PersonMainMenu teacher = new PersonMainMenu();
            PersonMainMenu student = new PersonMainMenu();
            PersonMainMenu parent  = new PersonMainMenu();

            Console.WriteLine("Teachers first name: " + teacher.parentsFirstName + "\nSur name: " + teacher.parentsSurName + "\nLast name: " + teacher.teachersLastName +
                "\nWork ID: " + teacher.teachersID + "\nPhone number: " + teacher.teachersPhoneNumber + "\nProfession: " + teacher.teachersProfession + '\n');

            Console.WriteLine("Students first name: " + student.studentsFirstName + "\nSur name: " + student.studentsSurName + "\nLast name: " + student.studentsLastName +
                "\nStudent ID: " + student.studentsID + "\nPhone number: " + student.studentsPhoneNumber + "\nStudents level of collegiate education: " + student.level + "th grade.\n");

            Console.WriteLine("The roles presented by!\nParents first name: " + parent.parentsFirstName + "\nSur name: " + parent.parentsSurName + "\nLast name: " + parent.parentsLastName +
                "\nID: " + parent.parentsID + "\nPhone number: " + parent.parentsPhoneNumber + "\nProfession: " + parent.parentsProfession + '\n');
        }

        // TODO end
    }
}