using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Work_1_SchoolProj_V666
{
    class Diary : Person
    {
        public Diary() { }

        private static Diary instance  = null;
        public static List<int> grades = new List<int>();

        public static Diary Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Diary();
                }

                return instance;
            }
        }

        // TODO end
    }
}