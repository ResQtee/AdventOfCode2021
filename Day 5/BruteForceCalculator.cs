using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_5
{
    internal class BruteForceCalculator
    {
        public int CalculateExample()
        {
            var lines = HydrothermalVentInputReader.ReadExample();
            return CountOverlappedPoints(FilterDiagonalLinesOut(lines));
        }

        public int CalculateExample2()
        {
            var lines = HydrothermalVentInputReader.ReadExample();
            return CountOverlappedPoints(lines);
        }

        public int CalculatePart1()
        {
            var lines = HydrothermalVentInputReader.ReadHydroventsListPart1();
            return CountOverlappedPoints(FilterDiagonalLinesOut(lines));
        }

        public int CalculatePart2()
        {
            var lines = HydrothermalVentInputReader.ReadHydroventsListPart1();
            return CountOverlappedPoints(lines);
        }

        private List<HydrothermalVentLine> FilterDiagonalLinesOut(List<HydrothermalVentLine> lines)
        {
            return lines.Where(line =>
               line.BeginLinePoint.X == line.EndLinePoint.X
               || line.BeginLinePoint.Y == line.EndLinePoint.Y).ToList();
        }

        private int CountOverlappedPoints(List<HydrothermalVentLine> lines)
        {
            var allCoordinates = new List<Point>();
            foreach (var line in lines)
            {
                allCoordinates.AddRange(line.LinePoints());
            }            
            var distinctCoordinates = allCoordinates.Distinct().ToList();            

            var parallelCount = new ConcurrentBag<int>();
            Parallel.ForEach(distinctCoordinates, point =>
            {
                parallelCount.Add(allCoordinates.Count(c => c.X == point.X && c.Y == point.Y));
            });
            
            return parallelCount.Count(count => count > 1);

        }
    }
}
