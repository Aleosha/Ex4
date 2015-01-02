using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            displayInterfacesMenu();
            displayDelegatesMenu();
        }

        private static void displayDelegatesMenu()
        {
            //Create main menu
            //Add Words counter to main menu
            //Add date sub menu to main menu
            //Add Show date to sub menu
            //Add Show time to sub menu
            //Add Show version to main menu
        }

        private static void displayInterfacesMenu()
        {
            //Create main menu
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu();
            //Add Words counter to main menu
            //Add date sub menu to main menu
            //Add Show date to sub menu
            //Add Show time to sub menu
            //Add Show version to main menu
        }
    }
}
