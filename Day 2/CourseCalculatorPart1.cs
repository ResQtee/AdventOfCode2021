using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_2
{
    internal class CourseCalculatorPart1
    {
        public static (int Depth, int Position) CalculateCourseExample()
        {
            var courseChanges = CourseInputReader.CourseExample();
            return CalculateCoursePart1(courseChanges);
        }

        public static (int Depth, int Position) CalculateCourse()
        {
            var courseChanges = CourseInputReader.CoursePart1();
            return CalculateCoursePart1(courseChanges);
        }

        private static (int Depth, int Position) CalculateCoursePart1(List<Course> courseChanges)
        {
            int depth = 0;
            int position = 0;

            foreach (var course in courseChanges)
            {
                switch(course.Direction)
                {
                    case Direction.Up:
                        depth -= course.TraveledDistance;
                        break;
                    case Direction.Down:
                        depth += course.TraveledDistance;
                        break;
                    case Direction.Foward:
                        position += course.TraveledDistance;
                        break;
                    case Direction.None:
                        break;
                }
            }

            return (depth, position);
        }
        
        
    }
}
