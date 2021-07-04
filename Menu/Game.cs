using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Menu
{
    class Game
    {
        public void Start()
        {
            Title = "Jumping Game";
            RunMainMenu();
            WriteLine("press any key to exit...");
            ReadKey(true);

        }
        private void RunMainMenu()
        {
            string prompt = @"
   ___                       _                                          
  |_  |                     (_)                                         
    | |_   _ _ __ ___  _ __  _ _ __   __ _    __ _  __ _ _ __ ___   ___ 
    | | | | | '_ ` _ \| '_ \| | '_ \ / _` |  / _` |/ _` | '_ ` _ \ / _ \
/\__/ / |_| | | | | | | |_) | | | | | (_| | | (_| | (_| | | | | | |  __/
\____/ \__,_|_| |_| |_| .__/|_|_| |_|\__, |  \__, |\__,_|_| |_| |_|\___|
                      | |             __/ |   __/ |                     
                      |_|            |___/   |___/                      
";
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
               
            }
        }
         private void ExitGame()
        {
            WriteLine("\nPress any key");
            ReadKey(true);
            Environment.Exit(0);
        }
        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("this is our game guid");
            ReadKey(true);
            RunMainMenu();
        }
        private void RunFirstChoice()
        {
       
           string prompt="what color paint could you like to watch dry?";
            string[] options = { "red", "Green", "Blue","yellow"};
            Menu colorMenu = new Menu(prompt, options);
            int SelectedIndex = colorMenu.Run();
            BackgroundColor = ConsoleColor.White;
            switch (SelectedIndex)
            {
                case 0:
                    BackgroundColor = ConsoleColor.Red;
                    WriteLine("one");
                    break;
                case 1:
                    BackgroundColor = ConsoleColor.Green;
                    WriteLine("two");
                    break;
                case 2:
                    BackgroundColor = ConsoleColor.Blue;
                    WriteLine("three");
                    break;
                case 3:
                    BackgroundColor = ConsoleColor.Yellow;
                    WriteLine("four");
                    break;
            }
            ResetColor();
            WriteLine("thats all for this game till now");
            ExitGame();
        }
       }
}
