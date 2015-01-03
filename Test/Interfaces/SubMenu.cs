using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class SubMenu : MenuItemContainer, IMenuItem
    {
    

        public SubMenu(string i_MenuName)
        {
            this.Name = i_MenuName;
        }

      

        protected override void ShowQuitOption()
        {
            Console.WriteLine(String.Format("{0}. {1}", 0, "Back"));
        }
    }
}
