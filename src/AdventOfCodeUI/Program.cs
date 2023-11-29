using AdventOfCodeUI.Controllers;

namespace AdventOfCodeUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenuController mainMenu = new();

            mainMenu.printMenuOptions();
        }
    }
}