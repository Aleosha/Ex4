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

        protected void ShowMenuItems()
        {
            int count = 1;
            foreach(IMenuItem menuItem in m_MenuItems)
            {
                Console.WriteLine(String.Format("{0}. {1}", count++, menuItem.Name));
            }
        }

        public abstract void Show();

        protected bool isOptionValid(int i_MenuOption)
        {
            return (i_MenuOption >= 0 && i_MenuOption <= m_MenuItems.Count);            
        }
        
        protected IMenuItem getMenuItem(int i_Option)
        {
            return m_MenuItems[i_Option-1];
        }

        
    }
}
