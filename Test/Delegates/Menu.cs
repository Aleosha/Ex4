using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Menu : MenuItem
    {
        List<MenuItem> m_MenuItems = new List<MenuItem>();
        bool m_IsMainMenu;

        public bool IsMainMenu
        {
            get { return m_IsMainMenu; }
            set { m_IsMainMenu = value; }
        }

        public Menu(string i_Name, bool i_IsMainMenu): base(i_Name)
        {
            m_IsMainMenu = i_IsMainMenu;
        }

        public void Show()
        {
            bool choseEndMenu = false;
            int chosenOption;
            do
            {
                Console.Clear();
                showMenuName();
                showMenuItems();
                showEndMenuOption();
                chosenOption = askUserForInput();
                if (chosenOption == 0)
                {
                    choseEndMenu = true;
                }
                else
                {
                    m_MenuItems[chosenOption-1].Choose();
                }
            } while (!choseEndMenu);
        }

        private int askUserForInput()
        {
            int option;
            bool isValidInput = false;

            do
            {
                Console.WriteLine("Please choose your option");


                if (int.TryParse(Console.ReadLine(), out option) && isOptionValid(option))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }

            } while (!isValidInput);

            return option;

        }

        private bool isOptionValid(int i_MenuOption)
        {
            return (i_MenuOption >= 0 && i_MenuOption <= m_MenuItems.Count);   
        }


        private void showEndMenuOption()
        {
            string endMenuOption;
            if (m_IsMainMenu)
            {
                endMenuOption = "Exit";
            }
            else
            {
                endMenuOption = "Back";
            }
            Console.WriteLine("0. " + endMenuOption);
        }

        private void showMenuItems()
        {
            int i = 1;
            foreach (MenuItem menuItem in m_MenuItems)
            {
                Console.WriteLine(i + ". " + menuItem.ItemName);
                i++;
            }
        }

        private void showMenuName()
        {
            Console.WriteLine(new string('-', m_ItemName.Length));
            Console.WriteLine(m_ItemName);
            Console.WriteLine(new string('-', m_ItemName.Length));
        }

        public void Add(MenuItem i_MenuItem)
        {
            if (i_MenuItem is ActionItem)
            {
                ((ActionItem)i_MenuItem).AttachFinishedActionObserver(this.Show);
            }
            m_MenuItems.Add(i_MenuItem);
        }

        public override void Choose()
        {
            Show();
        }
    }
}
