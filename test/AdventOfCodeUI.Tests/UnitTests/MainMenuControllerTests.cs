using AdventOfCodeUI.Controllers;
using AdventOfCodeUI.Models;

namespace AdventOfCodeUI.Tests.UnitTests
{
    public class Tests
    {
        private MainMenuController _sut;
        private MenuInputsModel _menuInputs;

        [SetUp]
        public void Setup()
        {
            _sut = new();
            _menuInputs = new();
        }

        [Test]
        public void GetMainMenuChoice_ValidInputs_ReturnInputString()
        {
            var inputs = _menuInputs.ValidInputs;

            foreach (var input in inputs)
            {
                Assert.That(_sut.GetMainMenuChoice(input), Is.EqualTo(input));
            }
        }

        [TestCase("EXIT")]
        [TestCase("Exit")]
        [TestCase("exiT")]
        [TestCase("exIt")]
        [TestCase("eXit")]
        public void GetMainMenuChoice_ValidInputInUpper_ReturnInputStringInLower(string input)
        {
            Assert.That(_sut.GetMainMenuChoice(input), Is.EqualTo(input.ToLower()));
        }

        [TestCase(" 2022", ExpectedResult = "2022")]
        [TestCase("2023 ", ExpectedResult = "2023")]
        [TestCase(" e x i t ", ExpectedResult = "exit")]
        public string GetMainMenuChoice_ValidInputContainsWhitespace_ReturnInputWithoutWhitespaces(string input)
        {
            return _sut.GetMainMenuChoice(input);
        }
    }
}