using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_2
{
    internal class CourseInputReader
    {
        internal static List<Course> CourseExample()
        {
            return new List<Course>
            {
                new Course{Direction=Direction.Foward, Position=5},
                new Course{Direction=Direction.Down, Position=5},
                new Course{Direction=Direction.Foward, Position=8},
                new Course{Direction=Direction.Up, Position=3},
                new Course{Direction=Direction.Down, Position=8},
                new Course{Direction=Direction.Foward, Position=2},
            };
        }
        internal static List<Course> CoursePart1()
        {
            return ReadCourseInput(@".\Day 2\Input\Course1.txt");
        }

        internal static List<Course> CoursePart2()
        {
            return ReadCourseInput(@".\Day 2\Input\Course2.txt");
        }


        private static List<Course> ReadCourseInput(string file)
        {
            var lines = File.ReadAllLines(file);
            return lines.Select(line => ParseCourse(line)).ToList();
        }

        private static Course ParseCourse(string courseText)
        {
            var splittedCourseText = courseText.Trim().Split(' ');
            return new Course
            {
                Direction = GetDirectionFromText(splittedCourseText[0]),
                Position = int.Parse(splittedCourseText[1]),
            };
        }

        private static Direction GetDirectionFromText(string directionText)
        {
            switch (directionText.ToLower())
            {
                case "forward":
                    return Direction.Foward;
                case "down":
                    return Direction.Down;
                case "up":
                    return Direction.Up;
                default:
                    return Direction.None;
            }
        }
    }


    public class Course
    {
        public int Position { get; set; }
        public Direction Direction { get; set; }
    }

    public enum Direction
    {
        None,
        Foward,
        Down,
        Up,
    }
}