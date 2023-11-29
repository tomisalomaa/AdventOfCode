using AdventOfCodeUI.Models;
using System.Text.RegularExpressions;

namespace AdventOfCodeUI.Controllers
{
    public class MainMenuController
    {
        private readonly MenuInputsModel _menuInputs;
        private static readonly Regex _stringWhitespace = new(@"\s+");

        public MainMenuController()
        {
            _menuInputs = new();
        }

        public void printMenuOptions()
        {
            string userChoice = null;

            Console.WriteLine("ADVENT OF CODE");
            Console.Write(new string('*', 20));
            Console.WriteLine("\nChoose a year\n");
            Console.WriteLine("1) 2022");
            Console.WriteLine("2) 2023");
            Console.WriteLine("x) Exit\n");

            while (!IsUserChoiceValid(userChoice))
            {
                Console.Write("Choose: ");
                userChoice = RemoveWhitespace(Console.ReadLine());
            }
        }

        public bool IsUserChoiceValid(string input)
        {
            HashSet<string> validInputs = new HashSet<string>
            {
                "1",
                "2",
                "2022",
                "2023",
                "x",
                "exit"
            };

            return validInputs.Contains(input?.ToLower());
        }

        public string RemoveWhitespace(string input)
        {
            return (string.IsNullOrWhiteSpace(input)
                ? input
                : _stringWhitespace.Replace(input, ""));
        }
    }
}
