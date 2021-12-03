using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_2
{
    internal class CourseCalculatorPart2
    {
        public static (int Depth, int Position, int Aim) CalculateCourseExample()
        {
            var courseChanges = CourseInputReader.CourseExample();
            return CalculateCourse(courseChanges);
        }

        public static (int Depth, int Position, int Aim) CalculateCourse()
        {
            var courseChanges = CourseInputReader.CoursePart2();
            return CalculateCourse(courseChanges);
        }

        private static (int Depth, int Position, int Aim) CalculateCourse(List<Course> courseChanges)
        {
            int depth = 0;
            int position = 0;
            int aim = 0;

            foreach (var course in courseChanges)
            {
                switch (course.Direction)
                {
                    case Direction.Up:
                        aim -= course.TraveledDistance;
                        break;
                    case Direction.Down:
                        aim += course.TraveledDistance;
                        break;
                    case Direction.Foward:
                        position += course.TraveledDistance;
                        depth += course.TraveledDistance * aim;
                        break;
                    case Direction.None:
                        break;
                }
            }

            return (depth, position, aim);
        }
    }
}
