
using System;

namespace A_Work_1_SchoolProj_V666
{
    class Person
    {
        public readonly string teachersFirstName = "Alan"; // Teacher info
        public readonly string teachersSurName   = "Jerome";
        public readonly string teachersLastName  = "Pasternak";
        public readonly byte teachersID          = 1;
        public readonly string teachersPhoneNumber = "+1-202-555-0111";
        public readonly string teachersProfession  = "Professor - High school teacher";

        public readonly string studentsFirstName = "Jennifer"; // Student info
        public readonly string studentsSurName   = "Amanda";
        public readonly string studentsLastName  = "Harper";
        public readonly short studentsID         = 500;
        public readonly string studentsPhoneNumber = "+1-202-555-0136";
        public readonly byte level = 10;

        public readonly string parentsFirstName = "Charles"; // Parent info
        public readonly string parentsSurName   = "Francis";
        public readonly string parentsLastName  = "Harper";
        public readonly string parentsID        = "03005988";
        public readonly string parentsPhoneNumber = "+1-202-555-0181";
        public readonly string parentsProfession  = "Fund Manager";

        // Teacher constructor
        public Person(string teachersFirstName, string teachersSurName, string teachersLastName, byte teachersID, string teachersPhoneNumber, string teachersProfession)
        {
            this.teachersFirstName = teachersFirstName;
            this.teachersSurName   = teachersSurName;
            this.teachersLastName  = teachersLastName;
            this.teachersID        = teachersID;
            this.teachersPhoneNumber = teachersPhoneNumber;
            this.teachersProfession  = teachersProfession;
        }

        // Parent constructor
        public Person(string parentsFirstName, string parentsSurName, string parentsLastName, string parentsID, string parentsPhoneNumber, string parentsProfession)
        {
            this.parentsFirstName = parentsFirstName;
            this.parentsSurName   = parentsSurName;
            this.parentsLastName  = parentsLastName;
            this.parentsID        = parentsID;
            this.parentsPhoneNumber = parentsPhoneNumber;
            this.parentsProfession  = parentsProfession;
        }

        // Student constructor
        public Person(string studentsFirstName, string studentsSurName, string studentsLastName, short studentsID, string parentsPhoneNumber, byte level)
        {
            this.studentsFirstName = studentsFirstName;
            this.studentsSurName   = studentsSurName;
            this.studentsLastName  = studentsLastName;
            this.studentsID        = studentsID;
            this.parentsPhoneNumber = parentsPhoneNumber;
            this.level = level;
        }

        public Person() {  } // Empty ctor

        // TODO end
    }
}