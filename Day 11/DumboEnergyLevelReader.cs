using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_11
{
    internal class DumboEnergyLevelReader
    {
        public DumboOctopus[,] Read(string file)
        {
            var lines = File.ReadAllLines(file);
            return CreateDumboOctopusMap(lines);
        }

        public DumboOctopus[,] CreateDumboOctopusMap(string[] lines)
        {
            var dumboOctopusMap = new DumboOctopus[lines.Length, lines[0].Length];
            
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    dumboOctopusMap[i, j] = new DumboOctopus((int)char.GetNumericValue(lines[i][j]));
                }
            }

            return dumboOctopusMap;
        }
    }
}
