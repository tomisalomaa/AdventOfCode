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
        public bool Part1Completed;
        public bool Part2Completed;

        public bool IsPart1Complete
        {
            get { return Part1Completed; }
        }

        public bool IsPart2Complete
        {
            get { return Part2Completed; }
        }
    }

    public class Year2022 : Year
    {
        public Year2022()
        {
            for (int i = 0; i < 18; i++)
            {
                Days[i].Part1Completed = true;
                Days[i].Part2Completed = true;
            }
        }
    }

    public class Year2023 : Year
    {
        // will be updated
    }
}