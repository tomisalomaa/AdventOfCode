using AdventOfCodeUI.Models;
using AdventOfCodeUI.Options;
using System.Text.RegularExpressions;

namespace AdventOfCodeUI.Controllers
{
    public class MainMenuController
    {
        private readonly MenuInputsModel _menuInputs;
        private readonly YearEvent _yearEvent;
        private static readonly Regex _stringWhitespace = new(@"\s+");

        public MainMenuController()
        {
            _menuInputs = new();
            _yearEvent = new();
        }

        public string GetMainMenuChoice(string input = null)
        {
            string userChoice = null;
            int optionIndex = 1;

            Console.WriteLine("ADVENT OF CODE");
            Console.Write(new string('*', 20));
            Console.WriteLine("\nChoose a year\n");

            foreach (var year in _yearEvent.YearEvents.Keys)
            {
                Console.WriteLine($"{optionIndex}) {year}");
                optionIndex++;
            }
            
            Console.WriteLine("x) Exit\n");

            while (!IsUserChoiceValid(userChoice))
            {
                Console.Write("Choose: ");
                userChoice = (
                    string.IsNullOrWhiteSpace(input) 
                    ? ReadMainMenuOptionInput()
                    : ReadMainMenuOptionInput(input));
            }

            return userChoice.ToLower();
        }

        private bool IsUserChoiceValid(string input)
        {
            HashSet<string> validInputs = _menuInputs.ValidInputs;

            return validInputs.Contains(input?.ToLower());
        }

        private string RemoveWhitespace(string input)
        {
            return (string.IsNullOrWhiteSpace(input)
                ? input
                : _stringWhitespace.Replace(input, ""));
        }

        private string ReadMainMenuOptionInput()
        {
            return RemoveWhitespace(Console.ReadLine());
        }

        private string ReadMainMenuOptionInput(string input)
        {
            return RemoveWhitespace(input);
        }
    }
}
