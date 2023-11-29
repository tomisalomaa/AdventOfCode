using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeUI.Options
{
    public class YearEvent
    {
        public OrderedDictionary YearEvents = new();

        public YearEvent()
        {
            YearEvents.Add("2022", new Year2022());
            YearEvents.Add("2023", new Year2023());
        }
    }

    public class Year
    {
        public Day[] Days { get; } = new Day[25];

        public Year()
        {
            for (int i = 0; i < 25; i++)
            {
                Days[i] = new();
            }
        }
    }

    public class Day
    {
        private bool Part1Completed;
        private bool Part2Completed;

        public bool IsPart1Complete
        {
            get { return Part1Completed; }
        }

        public bool IsPart2Complete
        {
            get { return Part2Completed; }
        }

        public void SetPart1True()
        {
            Part1Completed = true;
        }

        public void SetPart2True()
        {
            Part2Completed = true;
        }

        public void SetPart1False()
        {
            Part1Completed = false;
        }

        public void SetPart2False()
        {
            Part2Completed = false;
        }
    }

    public class Year2022 : Year
    {
        public Year2022()
        {
            var daysCompleted = 18;

            for (int i = 0; i < daysCompleted; i++)
            {
                Days[i].SetPart1True();
                Days[i].SetPart2True();
            }
        }
    }

    public class Year2023 : Year
    {
        // will be updated
    }
}