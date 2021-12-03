using AdventOfCode2021.Day_2;

namespace AdventOfCode2021.Fluff
{
    internal class Submarine
    {
        private IElfNavigator navigator;

        public Submarine(IElfNavigator elfNavigator)
        {
            navigator = elfNavigator;
        }

        public int Depth { get; set; } = 0;
        public int Position { get; set; } = 0;
        public int Aim { get; set; } = 0;

        public (int newDepth, int newPosition, int aim) PlotCourse(List<Course> courseChanges)
        {
            return navigator.PlotCourse(Depth, Position, Aim, courseChanges);            
        }
    }
}
