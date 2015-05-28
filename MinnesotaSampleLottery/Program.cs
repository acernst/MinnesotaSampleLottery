using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinnesotaSampleLottery.DAL;
using MinnesotaSampleLottery.Common;

namespace MinnesotaSampleLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleApplication();
        }

        public static void SampleApplication()
        {
            start:
            Menu.MenuDisplay();

            GameCollection showGames = GameDAL.GetCollection();

            foreach (Game display in showGames)
                System.Console.WriteLine(display.GameId + " " + display.Name);

            System.Console.WriteLine("Enter one of the game Id's above to view their details");

            int input = System.Console.ReadLine().ToInt();
            System.Console.WriteLine(" ");

            Game details = GameDAL.GetItem(input);

            System.Console.WriteLine("Selected: " + details.Name);
            System.Console.WriteLine("Number Drawn: " + details.NumbersDrawn);
            System.Console.WriteLine("Multiplier: " + details.Multiplier);
            System.Console.WriteLine("Game Details: " + details.Description);
            
            System.Console.WriteLine("\nPress 1 to restart or press 2 to end program");

            int nextStep = System.Console.ReadLine().ToInt();
            switch (nextStep)
            {
                case 1:
                    System.Console.Clear();
                    goto start;
                    break;

                case 2:
                    goto end;
                    break;
            }

        end: ;
        }
    }
}
