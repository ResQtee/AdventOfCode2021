using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_12
{
    public class Cave
    {
        private readonly List<Cave> connectedCaves = new List<Cave>();

        public Cave(string designation, bool isLargeCave)
        {
            Designation = designation;
            IsLargeCave = isLargeCave;
        }

        public List<Cave> ConnectedCaves => connectedCaves.OrderBy(c => c.Designation).ToList();
        public bool IsLargeCave { get; }
        public string Designation { get; }

        public void AddConnectedCave(Cave connectedCave)
        {
            connectedCaves.Add(connectedCave);
        }
    }
}
