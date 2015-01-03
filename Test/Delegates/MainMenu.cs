using System;
using System.Collections.Generic;
using System.Text;


namespace Delegates
{
    public class MainMenu
    {
        private List<MenuItem> menuItems = new List<MenuItem>();

        public MainMenu()
        {
            Show();
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine("this is the delegates main menu");
            Console.ReadLine();
        }
    }
}
