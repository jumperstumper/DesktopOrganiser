using DesktopOrganiser.Organizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopOrganiser
{
    public class MainMenu
    {

        private readonly Organize organize;

        public MainMenu(Organize organize)
        {
            this.organize = organize;
        }

        public void StartMenu()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Welcome!");
            Console.WriteLine("Your last orgianze was " + DateTime.UtcNow);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Press 1 to organize your desktop!");

            bool isNumber = int.TryParse(Console.ReadLine(), out int start);

            if (isNumber)
            {
                switch (start)
                {
                    case 1:
                       organize.CleanDesktop();
                        break;
                    default:
                        break;
                };

            }
            else
            {
                Console.WriteLine("Please enter a number");
            }
        }
    }
}

