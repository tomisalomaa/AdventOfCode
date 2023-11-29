namespace AdventOfCodeUI.Models
{
    public class MenuInputsModel
    {
        public MenuInputsModel() { }

        public HashSet<string> ValidInputs { get; } = new HashSet<string>
        {
            "1",
            "2",
            "2022",
            "2023",
            "x",
            "exit"
        };
    }
}
