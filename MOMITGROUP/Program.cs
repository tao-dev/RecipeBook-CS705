using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//added this so as to read files


namespace Amanda_Recipe_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //main method
            // Console application starts from here.

            MainMenu mm = new MainMenu();            
            mm.showMainMenuScreen();


            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
