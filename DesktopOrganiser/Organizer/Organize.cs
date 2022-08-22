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

                string photoFolder = @"C:\Users\danii\OneDrive\Skrivbord\Photos";
                string textFolder = @"C:\Users\danii\OneDrive\Skrivbord\TextFiles";

                System.IO.Directory.CreateDirectory(photoFolder);
                System.IO.Directory.CreateDirectory(textFolder);


                string[] textFiles;
                string[] photoFiles;

                textFiles = new string[] {".txt",".docx",".zip"};
                photoFiles = new string[] {".pdf",".png",".jpg", ".webp" };


                foreach (var word in textFiles)
                {
                    if (item.Contains(word))
                    {
                        string fileName = item.Substring(34);

                        File.Move(item, textFolder + @"\" + fileName);

                    }
                   
                }

                foreach (var word in photoFiles)
                {
                    if (item.Contains(word))
                    {
                        string fileName = item.Substring(34);

                        File.Move(item, photoFolder + @"\" + fileName);

                    }
                }


                
            }

          


        }
    }
}
