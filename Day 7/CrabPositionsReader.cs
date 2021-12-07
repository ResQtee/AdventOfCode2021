using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_7
{
    internal class CrabPositionsReader
    {
        public static List<int> ReadCrabPositions(string file)
        {
            var text = File.ReadAllText(file);
            return text.Trim().Split(',').Select(t => int.Parse(t)).ToList();
        }
    }
}
