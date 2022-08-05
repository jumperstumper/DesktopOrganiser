using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopOrganiser
{
    public class Start
    {
        private readonly MainMenu menu;

        public Start(MainMenu menu)
        {
            this.menu = menu;
        }

        public void Run()
        {
            while (true)
            {
                menu.StartMenu();
            
            }
        }


    }
}
