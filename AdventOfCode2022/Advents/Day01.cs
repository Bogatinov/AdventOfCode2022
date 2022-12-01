namespace AdventOfCode2022.Advents
{
    public class Day01 : DayAdvent<int>
    {
        public Day01(string filePath) : base(filePath)
        {
        }

        public override int Solve1()
        {
            var result = int.MinValue;
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
            var queue = new PriorityQueue<int, int>();
            var elfCalories = 0;
            foreach (var line in Lines)
            {
                if (line == string.Empty)
                {
                    queue.Enqueue(elfCalories, -1 * elfCalories);
                    elfCalories = 0;
                    continue;
                }

                elfCalories += int.Parse(line);
            }
            queue.Enqueue(elfCalories, -1 * elfCalories);

            var best = queue.Dequeue();
            var second = queue.Dequeue();
            var third = queue.Dequeue();

            return best + second + third;
        }
    }
}
