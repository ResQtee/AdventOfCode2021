using AdventOfCode2021.Day_2;

namespace AdventOfCode2021.Fluff
{
    internal interface IElfNavigator
    {
        public (int newDepth, int newPosition, int aim) ChangeCourse(int depth, int position, int aim, Course course);
        public (int newDepth, int newPosition, int aim) PlotCourse(int depth, int position, int aim, List<Course> courseChanges);
    }
}