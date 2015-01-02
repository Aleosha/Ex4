using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class MenuItemContainer : IMenuItem
    {

        List<IMenuItem> m_MenuItems = new List<IMenuItem>();

        public void Add(IMenuItem i_MenuItem)
        {
            throw new NotImplementedException();
        }

        protected void ShowMenuItems()
        {

        }

        public abstract void Show();
        
    }
}
