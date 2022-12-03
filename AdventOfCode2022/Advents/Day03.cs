using System.Numerics;

namespace AdventOfCode2022.Advents
{
    public class Day03 : DayAdvent<int>
    {
        private const int BitsCount = 63;

        public Day03(string filePath) : base(filePath)
        {
        }

        public override int Solve1()
        {
            var result = 0;
            foreach (var line in Lines)
            {
                ulong set1 = 0, set2 = 0;
                for (int i = 0; i < line.Length / 2; i++)
                {
                    set1 |= 1UL << (line[i] - 'A');
                    set2 |= 1UL << (line[i + line.Length / 2] - 'A');
                }

                //https://andrewlock.net/counting-the-leading-zeroes-in-a-binary-number/
                var bits = BitsCount - BitOperations.LeadingZeroCount(set1 & set2);
                result += bits + (bits > 25 ? -31 : 27);
            }

            return result;
        }

        public override int Solve2()
        {
            int result = 0, count = 1;
            var group = ulong.MaxValue;
            foreach (var line in Lines)
            {
                ulong set1 = 0, set2 = 0;
                for (int i = 0; i < line.Length / 2; i++)
                {
                    set1 |= 1UL << (line[i] - 'A');
                    set2 |= 1UL << (line[i + line.Length / 2] - 'A');
                }

                group &= set1 | set2;
                if (count++ % 3 == 0)
                {
                    var bits = BitsCount - BitOperations.LeadingZeroCount(group);
                    result += bits + (bits > 25 ? -31 : 27);
                    group = ulong.MaxValue;
                }

            }

            return result;
        }
    }
}
