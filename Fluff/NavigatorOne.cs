using AdventOfCode2021.Day_2;

namespace AdventOfCode2021.Fluff
{
    public class NavigatorOne : IElfNavigator
    {
        public (int newDepth, int newPosition, int aim) ChangeCourse(int currentDepth, int currentPosition, int aim, Course course)
        {
            switch (course.Direction)
            {                    
                case Direction.Foward:
                    return (currentDepth, currentPosition + course.Position, 0);
                case Direction.Down:
                    return (currentDepth + course.Position, currentPosition, 0);
                case Direction.Up:
                    return (currentDepth - course.Position, currentPosition, 0);
                default:
                    return (currentDepth, currentPosition, 0);
            }            
        }

        public (int newDepth, int newPosition, int aim) PlotCourse(int depth, int position, int aim, List<Course> courseChanges)
        {
            // Aye Aye captain, plotting course.
            var newDepth = depth;
            var newPosition = position;

            foreach (var courseChange in courseChanges)
            {
                var (calculatedDepth, calculatedPosition, calculatedAim) = ChangeCourse(newDepth, newPosition, 0, courseChange);
                newDepth = calculatedDepth;
                newPosition = calculatedPosition;
            }

            return (newDepth, newPosition, 0);
        }
    }
}