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
           
            Console.WriteLine("This is the main menu");
            int option;

            do
            {
                option = getOptionFromUser();

                if (option > 0)
                {
                    IMenuItem chosenOption = getMenuItem(option);

                    if (chosenOption is IActionMenuItem)
                    {
                        (chosenOption as IActionMenuItem).DoAction();
                    }
                }                

            } while (option != 0);
        }

 

        private int getOptionFromUser()
        {
            int option;
            bool isValidInput = false;

            do
            {
                Console.WriteLine("Please choose your option");
                ShowMenuItems();
                Console.WriteLine(String.Format("{0}. {1}", 0, "Exit"));

                if (int.TryParse(Console.ReadLine(), out option) && isOptionValid(option))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }

            } while (!isValidInput);

            return option;
        }
    }
}
