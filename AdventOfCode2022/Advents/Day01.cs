using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2022.Advents
{
    public class Day01 : DayAdvent<int>
    {
        public Day01(string filePath) : base(filePath)
        {
        }

        public override int Solve1()
        {
            var result = 0;
            var elfCalories = 0;
            foreach (var line in Lines)
            {
                if (line == string.Empty)
                {
                    result = Math.Max(result, elfCalories);
                    elfCalories = 0;
                    continue;
                }

                elfCalories += int.Parse(line);
            }

            return Math.Max(result, elfCalories);
        }

        public override int Solve2()
        {
            int best, second, third, elfCalories;
            best = second = third = elfCalories = 0;
            foreach (var line in Lines)
            {
                if (line == string.Empty)
                {
                    SortMaxValues();
                    elfCalories = 0;
                    continue;
                }

                elfCalories += int.Parse(line);
            }

            SortMaxValues();

            return best + second + third;

            void SortMaxValues()
            {
                if (elfCalories > best)
                {
                    third = second;
                    second = best;
                    best = elfCalories;
                }
                else if (elfCalories > second)
                {
                    third = second;
                    second = elfCalories;
                }
                else if (elfCalories > third)
                    third = elfCalories;
            }
        }
    }
}
