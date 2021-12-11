using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_9
{
    internal class HeightMapReader
    {
        public HeightMap Read(string file)
        {
            var lines = File.ReadAllLines(file);
            return CreateHeightMap(lines);
        }

        private HeightMap CreateHeightMap(string[] lines)
        {
            double[,] heights = new double[lines.Length, lines[0].Length];
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    heights[i, j] = char.GetNumericValue(lines[i][j]);
                }
            }

            return new HeightMap(heights);
        }
    }
}
