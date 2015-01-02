using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public class SubMenu : MenuItemContainer, IMenuItem
    {
    

        public SubMenu(string i_MenuName)
        {
            this.Name = i_MenuName;
        }

        public override void Show()
        {

        }
    }
}
