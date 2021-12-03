using AdventOfCode2021.Day_2;

namespace AdventOfCode2021.Fluff
{
    public class NavigatorTwo : IElfNavigator
    {
        public (int newDepth, int newPosition, int aim) ChangeCourse(int currentDepth, int currentPosition, int aim, Course course)
        {
            switch (course.Direction)
            {                    
                case Direction.Foward:
                    return (currentDepth + (course.Position * aim), currentPosition + course.Position, aim);
                case Direction.Down:
                    return (currentDepth, currentPosition, aim + course.Position);
                case Direction.Up:
                    return (currentDepth, currentPosition, aim - course.Position);
                default:
                    return (currentDepth, currentPosition, aim);
            }            
        }

        public (int newDepth, int newPosition, int aim) PlotCourse(int depth, int position, int aim, List<Course> courseChanges)
        {
            // Aye Aye captain, plotting course.
            var newDepth = depth;
            var newPosition = position;
            var newAim = aim;

            foreach (var courseChange in courseChanges)
            {
                var (calculatedDepth, calculatedPosition, calculatedAim) = ChangeCourse(newDepth, newPosition, newAim, courseChange);
                newDepth = calculatedDepth;
                newPosition = calculatedPosition;
                newAim = calculatedAim;
            }

            return (newDepth, newPosition, newAim);
        }
    }
}