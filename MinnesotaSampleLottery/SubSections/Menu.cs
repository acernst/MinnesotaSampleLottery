using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinnesotaSampleLottery
{
    public class Menu
    {
        static void ShowMenu(string[] args)
        {
            MenuDisplay();
        }

        public static void MenuDisplay()
        {
            System.Console.WriteLine("================================================ \n\n" + 
                                     "   Welcome to the Minnesota Lottery Application \n\n"
                                     + "================================================");
            System.Console.WriteLine("\nPress any key to continue");
            System.Console.ReadLine();
        }
    }
}