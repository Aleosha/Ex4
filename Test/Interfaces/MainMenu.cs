using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class MainMenu : MenuItemContainer, IMenuItem
    {

        public MainMenu()
        {
            this.Name = "Main menu";
        }
        
        protected override void ShowQuitOption()
        {
            Console.WriteLine(String.Format("{0}. {1}", 0, "Exit"));
        }
    }
}
