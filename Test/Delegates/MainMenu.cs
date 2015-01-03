using System;
using System.Collections.Generic;
using System.Text;


namespace Delegates
{
    public class MainMenu
    {
        const bool v_IsMainMenu = true;
        private Menu m_MainMenu = new Menu("Main Menu", v_IsMainMenu);

        public MainMenu()
        {
            //Show();
        }

        public void Show()
        {
            m_MainMenu.Show();
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_MainMenu.Add(i_MenuItem);
        }
    }
}
