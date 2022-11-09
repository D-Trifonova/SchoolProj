using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Work_1_SchoolProj_V666
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonsInfo info = new PersonsInfo();
            info.Info();

            PersonMainMenu mainMenu = new PersonMainMenu();
            mainMenu.Choice();

            Console.ReadKey(true);
        }
    }
}