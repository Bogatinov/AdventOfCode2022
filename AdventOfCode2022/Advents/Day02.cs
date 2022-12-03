namespace AdventOfCode2022.Advents
{
    public class Day02 : DayAdvent<int>
    {
        /* A X = 4
        *  A Y = 1
        *  A Z = 7
        *  B X = 8
        *  B Y = 5
        *  B Z = 2
        *  C X = 3
        *  C Y = 9
        *  C Z = 6
        */
        private readonly short[] _map;

        public Day02(string filePath) : base(filePath)
        {
            _map = new short[] { 4, 1, 7, 8, 5, 2, 3, 9, 6 };
        }

        public override int Solve1()
        {
            var sum = 0;

            foreach (var line in Lines)
            {
                sum += _map[line[0] - 'A' + 3 * (line[2] - 'X')];
            }

            return sum;
        }

        public override int Solve2()
        {
            var sum = 0;

            foreach (var line in Lines)
            {
                var elf = line[0] - 'A';
                sum += _map[elf + 3 * ((line[2] - 'X' + 2 + elf) % 3)];
            }

            return sum;
        }
    }
}
