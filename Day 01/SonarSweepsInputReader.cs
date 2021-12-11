using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_1
{
    internal class SonarSweepsInputReader
    {
        public static List<int> SonarSweepsExample()
        {
            return new List<int> { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
        }

        public static List<int> SonarSweepsPart1()
        {
            return ReadSonarSweepsInput(@".\Day 1\Input\SonarSweeps1.txt");
        }

        public static List<int> SonarSweepsPart2()
        {
            return ReadSonarSweepsInput(@".\Day 1\Input\SonarSweeps2.txt");
        }

        private static List<int> ReadSonarSweepsInput(string file)
        {
            var lines = File.ReadAllLines(file);
            return lines.Select(line => int.Parse(line.Trim())).ToList();
        }
    }
}