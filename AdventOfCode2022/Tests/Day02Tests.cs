using AdventOfCode2022.Advents;

namespace AdventOfCode2022.Tests
{
    public class Day02TrainTests : DayAdventFixture<int>
    {
        public Day02TrainTests() : base(new Day02("Puzzles/day02_train.txt"))
        {
        }

        protected override int Expected1 => 15;
        protected override int Expected2 => 12;
    }

    public class Day02Tests : DayAdventFixture<int>
    {
        public Day02Tests() : base(new Day02("Puzzles/day02.txt"))
        {
        }

        protected override int Expected1 => 14069;
        protected override int Expected2 => 12411;
    }
}
