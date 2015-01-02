using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public class SubMenu : MenuItemContainer, IMenuItem
    {
        private readonly string r_MenuName;

        public SubMenu(string i_MenuName)
        {
            this.r_MenuName = i_MenuName;
        }

        public override void Show()
        {

        }
    }
}
