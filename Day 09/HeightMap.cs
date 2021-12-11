using System.Drawing;

namespace AdventOfCode2021.Day_9
{
    public class HeightMap
    {
        public HeightMap(double[,] heights)
        {
            Heights = heights;
        }

        public double[,] Heights { get; }
        
        public List<Point> FindLowPoints()
        {
            var lowPoints = new List<Point>();

            for (int i = 0; i < Heights.GetLength(0); i++)
            {
                for (int j = 0; j < Heights.GetLength(1); j++)
                {
                    double value = Heights[i, j];

                    // Up
                    if (i > 0 && Heights[i - 1, j] <= value)
                    {
                        continue;
                    }

                    // Right
                    if (j < Heights.GetLength(1)-1 && Heights[i, j + 1] <= value)
                    {
                        continue;
                    }

                    // Down
                    if (i < Heights.GetLength(0) - 1 && Heights[i + 1, j] <= value)
                    {
                        continue;
                    }

                    // Left
                    if (j > 0 && Heights[i, j - 1] <= value)
                    {
                        continue;
                    }                    

                    // none of the neighbours is lower...so low point found.
                    lowPoints.Add(new Point(i,j));
                }
            }

            return lowPoints;
        }

        public double CalculateRiskLevelSum(List<Point> lowPoints)
        {
            return lowPoints.Sum(lowPoint => Heights[lowPoint.X,lowPoint.Y]+1);
        }

        public List<int> Find3LargestBasin(List<int> basinSizes)
        {
            return basinSizes.OrderByDescending(size => size).Take(3).ToList();
        }

        public List<int> CalculateAllBasinSize(List<Point> lowPoints)
        {
            var basinSizes = new List<int>();
            foreach (var point in lowPoints)
            {
                var basin = new List<Point>();
                BasinSize(basin, point);
                basinSizes.Add(basin.Count);
            }

            return basinSizes;
        }

        
        private void BasinSize(List<Point> basin, Point location)
        {
            if (Heights[location.X, location.Y] == 9 || basin.Contains(location)) return;

            basin.Add(location);

            // Up
            if (location.X > 0)
            {
                BasinSize(basin, new Point(location.X-1, location.Y));
            }

            // Right
            if (location.Y < Heights.GetLength(1) - 1)
            {
                BasinSize(basin, new Point(location.X, location.Y+1));
            }

            // Down
            if (location.X < Heights.GetLength(0) - 1)
            {
                BasinSize(basin, new Point(location.X+1, location.Y));
            }

            // Left
            if (location.Y > 0)
            {
                BasinSize(basin, new Point(location.X, location.Y - 1));
            }
        }

    }
}