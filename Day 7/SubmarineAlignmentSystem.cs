using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_7
{
    internal class SubmarineAlignmentSystem
    {
        public (int Level, int FuelCost) CalculateBestAlignment(List<int> crabPositions, int beginLevel, int endLevel)
        {
            List<(int level, int fuelCost)> calculations = new List<(int, int)>();

            for (int i = beginLevel; i <= endLevel; i++)
            {
                calculations.Add((i,AlignOnLevel(i, crabPositions)));
            }

            var lowestCost = calculations.MinBy(c => c.fuelCost);

            return lowestCost;
        }

        public int AlignOnLevel(int level, List<int> crabPositions)
        {
            var fuelCost = crabPositions.Select(c => CalculateSpendFuel(c, level)).Sum();
            return fuelCost;            
        }

        protected virtual int CalculateSpendFuel(int oldPosition, int newPosition)
        {
            return Math.Abs(newPosition - oldPosition);
        }
    }

    internal class SubmarineAlignmentSystemPart2 : SubmarineAlignmentSystem
    {
        protected override int CalculateSpendFuel(int oldPosition, int newPosition)
        {
            int steps = Math.Abs(newPosition - oldPosition);

            int fuelCost = 0;
            for (int i = 0; i <= steps; i++)
            {
                fuelCost += i;
            }

            return fuelCost;
        }
    }
}
