using AdventOfCode2022.Advents;

namespace AdventOfCode2022.Tests
{
    public class Day03TrainTests : DayAdventFixture<int>
    {
        public Day03TrainTests() : base(new Day03("Puzzles/day03_train.txt"))
        {
        }

        protected override int Expected1 => 157;
        protected override int Expected2 => 70;
    }

    public class Day03Tests : DayAdventFixture<int>
    {
        public Day03Tests() : base(new Day03("Puzzles/day03.txt"))
        {
        }

        protected override int Expected1 => 7742;
        protected override int Expected2 => 2276;
    }
}
