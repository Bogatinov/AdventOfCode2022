using AdventOfCode2022.Advents;

namespace AdventOfCode2022.Tests
{
    public class Day01TrainTests : DayAdventFixture<int>
    {
        public Day01TrainTests() : base(new Day01("Puzzles/day01_train.txt"))
        {
        }

        protected override int Expected1 => 24000;

        protected override int Expected2 => 45000;
    }

    public class Day01Tests : DayAdventFixture<int>
    {
        public Day01Tests() : base(new Day01("Puzzles/day01.txt"))
        {
        }

        protected override int Expected1 => 67450;

        protected override int Expected2 => 199357;
    }
}
