﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public abstract class MenuItemContainer : IMenuItem
    {

        List<IMenuItem> m_MenuItems = new List<IMenuItem>();
        private string m_Name;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        

        public void Add(IMenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        protected void showMenuItems()
        {
            int count = 1;
            foreach(IMenuItem menuItem in m_MenuItems)
            {
                Console.WriteLine(String.Format("{0}. {1}", count++, menuItem.Name));
            }
            showQuitOption();
        }

        protected abstract void showQuitOption();

        protected bool isOptionValid(int i_MenuOption)
        {
            return (i_MenuOption >= 0 && i_MenuOption <= m_MenuItems.Count);            
        }
        
        protected IMenuItem getMenuItem(int i_Option)
        {
            return m_MenuItems[i_Option-1];
        }

        protected int getOptionFromUser()
        {
            int option;
            bool isValidInput = false;

            do
            {
                showMenuHeader();
                showMenuItems();
                Console.WriteLine("Please choose your option");


                if (int.TryParse(Console.ReadLine(), out option) && isOptionValid(option))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option");
                }

            } while (!isValidInput);

            return option;
        }

        public void ShowMenu()
        {
            
            int option;

            do
            {                
                option = getOptionFromUser();
                Console.Clear();
                if (option > 0)
                {
                    IMenuItem chosenOption = getMenuItem(option);

                    if (chosenOption is IActionMenuItem)
                    {
                        (chosenOption as IActionMenuItem).DoAction();
                    }
                    else if (chosenOption is MenuItemContainer)
                    {
                        (chosenOption as MenuItemContainer).ShowMenu();
                    }
                }

            } while (option != 0);
        }

        private void showMenuHeader()
        {
            string separator = new String('-', this.Name.Length);
            StringBuilder stringBuilder = new StringBuilder(separator).Append(Environment.NewLine).
                                              Append(this.Name).Append(Environment.NewLine).
                                              Append(separator);
            Console.WriteLine(stringBuilder.ToString());
        }
        
    }
}
