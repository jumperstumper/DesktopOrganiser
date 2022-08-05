using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopOrganiser.Organizer
{
   public class Organize
    {
        public void CleanDesktop()
        {
            Console.WriteLine("Starting to clean");

            var path = @"C:\Users\danii\OneDrive\Skrivbord";

            string[] dirs = Directory.GetFiles(path);

            

            foreach (var item in dirs)
            {
                //string files = ".txt";

                //List<string> files = new List<string> { "word1", "word2", "word3" }.ToList();

                //Skapa mapp här

                string photoFolder = @"C:\Users\danii\OneDrive\Skrivbord\Photos";
                string textFolder = @"C:\Users\danii\OneDrive\Skrivbord\TextFiles";

                System.IO.Directory.CreateDirectory(photoFolder);
                System.IO.Directory.CreateDirectory(textFolder);

                string textFile = ".txt";

                if (item.Contains(textFile))
                {

                }




            }

          


        }
    }
}
