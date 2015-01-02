using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
