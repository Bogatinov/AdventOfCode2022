namespace AdventOfCode2022.Advents
{
    public abstract class DayAdvent<T>
    {
        protected readonly string[] Lines;
        public DayAdvent(string filePath) => Lines = File.ReadAllLines(filePath);

        public abstract T Solve1();
        public abstract T Solve2();
    }
}
