using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class MainMenu : MenuItemContainer, IMenuItem
    {
        public override void Show()
        {
            bool isValidInput = false;
            Console.WriteLine("This is the main menu");
            int option;
            
            do
            {
                Console.WriteLine("Please choose your option");
                ShowMenuItems();

                if (int.TryParse(Console.ReadLine(), out option) && isOptionValid(option))
                {
                    isValidInput = true;
                }
            } while (!isValidInput);
        }
    }
}
