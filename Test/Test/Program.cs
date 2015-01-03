using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Program
    {
        private static Delegates.MainMenu m_DelegatesMainMenu;

        static void Main(string[] args)
        {
            displayInterfacesMenu();
            displayDelegatesMenu();
        }

        private static void displayDelegatesMenu()
        {
            //Create main menu
            m_DelegatesMainMenu = new Delegates.MainMenu();
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
            mainMenu.Add(new Interfaces.WordsCounter());

            Interfaces.SubMenu subMenu = new Interfaces.SubMenu("Show date/time");
            //Add date sub menu to main menu
            mainMenu.Add(subMenu);
            //Add Show date to sub menu
            subMenu.Add(new Interfaces.ShowDate());
            
            //Add Show time to sub menu
            subMenu.Add(new Interfaces.ShowTime());
            //Add Show version to main menu
            mainMenu.Add(new Interfaces.ShowVersion());

            mainMenu.Show();
        }
    }
}
