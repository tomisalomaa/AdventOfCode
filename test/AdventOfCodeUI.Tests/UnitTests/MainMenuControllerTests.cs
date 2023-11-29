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
        public void IsUserChoiceValid_ValidInputs_ReturnTrue()
        {
            var inputs = _menuInputs.ValidInputs;

            foreach (var input in inputs)
            {
                Assert.That(_sut.IsUserChoiceValid(input), Is.True);
            }
        }

        [TestCase("EXIT")]
        [TestCase("Exit")]
        [TestCase("exiT")]
        [TestCase("exIt")]
        [TestCase("eXit")]
        public void IsUserChoiceValid_ValidInputInUpper_ReturnTrue(string input)
        {
            Assert.That(_sut.IsUserChoiceValid(input), Is.True);
        }

        [TestCase(" hello", ExpectedResult = "hello")]
        [TestCase("hello ", ExpectedResult = "hello")]
        [TestCase(" h e l l o ", ExpectedResult = "hello")]
        [TestCase(null, ExpectedResult = null)]
        [TestCase("   ", ExpectedResult = "   ")]
        [TestCase("", ExpectedResult = "")]
        public string RemoveWhitespace_InputContainsWhitespace_ReturnInputWithoutWhitespaces(string input)
        {
            return _sut.RemoveWhitespace(input);
        }
    }
}