using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Program
    {
        private static Delegates.MainMenu m_DelegatesMainMenu;


        public static void Main(string[] args)
        {
            displayInterfacesMenu();
            displayDelegatesMenu();
        }

        private static void displayDelegatesMenu()
        {
            //Create main menu
            m_DelegatesMainMenu = new Delegates.MainMenu();
            //Insert word counter menu item to main menu:
            Delegates.ActionItem wordsCounter = new Delegates.ActionItem((int)eAction.WordsCounter, "Words Counter");
            wordsCounter.AttachDoActionObserver(DoAction);
            m_DelegatesMainMenu.AddMenuItem(wordsCounter);
            //Create show date/time sub menu:
            Delegates.Menu showDateTime = new Delegates.Menu("Show Date/Time", false);
            //Insert showDate menu item to showDateTime submenu:
            Delegates.ActionItem showDate = new Delegates.ActionItem((int)eAction.ShowDate, "Show Date");
            showDate.AttachDoActionObserver(DoAction);
            showDateTime.Add(showDate);
            ////Insert showTime menu item to showDateTime submenu:
            Delegates.ActionItem showTime = new Delegates.ActionItem((int)eAction.ShowTime, "Show Time");
            showTime.AttachDoActionObserver(DoAction);
            showDateTime.Add(showTime);
            //Insert showDateTime submenu MainMenu:
            m_DelegatesMainMenu.AddMenuItem(showDateTime);
            //Insert showVersion menu item to main menu:
            Delegates.ActionItem showVersion = new Delegates.ActionItem((int)eAction.ShowVersion, "Show version");
            showVersion.AttachDoActionObserver(DoAction);
            m_DelegatesMainMenu.AddMenuItem(showVersion);

            m_DelegatesMainMenu.Show();
        }

        private static void displayInterfacesMenu()
        {
            //Create main menu
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu();
            //Add Words counter to main menu
            mainMenu.Add(new Test.WordsCounterActionMenuItem());

            Interfaces.SubMenu subMenu = new Interfaces.SubMenu("Show date/time");
            //Add date sub menu to main menu
            mainMenu.Add(subMenu);
            //Add Show date to sub menu
            subMenu.Add(new Test.ShowDateActionMenuItem());
            
            //Add Show time to sub menu
            subMenu.Add(new Test.ShowTimeActionMenuItem());
            //Add Show version to main menu
            mainMenu.Add(new Test.ShowVersionActionMenuItem());

            mainMenu.Show();
        }

        public static void DoAction(int i_Action)
        {
            switch (i_Action)
            {
                case (int)eAction.WordsCounter:
                    CountWords();
                    break;
                case (int)eAction.ShowDate:
                    ShowDate();
                    break;
                case (int)eAction.ShowTime:
                    ShowTime();
                    break;
                case (int)eAction.ShowVersion:
                    ShowVersion();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }

        public static void ShowVersion()
        {
            Console.WriteLine("Version: 15.1.4.0");
        }

        public static void CountWords()
        {
            char[] wordsSeparator = {' '};
            int numOfWords;
            Console.WriteLine("Please enter a sentence for counting it's number of words");
            string sentence = Console.ReadLine();
            numOfWords = sentence.Split(wordsSeparator).Length;
            Console.WriteLine("Your sentence contains {0} words", numOfWords);
        }
    }
}
