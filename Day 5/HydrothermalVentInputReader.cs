using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_5
{
    internal class HydrothermalVentInputReader
    {
        public static List<HydrothermalVentLine> ReadExample()
        {
            return new List<HydrothermalVentLine>
            {
                new HydrothermalVentLine(new Point(0,9),new Point(5,9)),
                new HydrothermalVentLine(new Point(8,0),new Point(0,8)),
                new HydrothermalVentLine(new Point(9,4),new Point(3,4)),
                new HydrothermalVentLine(new Point(2,2),new Point(2,1)),
                new HydrothermalVentLine(new Point(7,0),new Point(7,4)),
                new HydrothermalVentLine(new Point(6,4),new Point(2,0)),
                new HydrothermalVentLine(new Point(0,9),new Point(2,9)),
                new HydrothermalVentLine(new Point(3,4),new Point(1,4)),
                new HydrothermalVentLine(new Point(0,0),new Point(8,8)),
                new HydrothermalVentLine(new Point(5,5),new Point(8,2)),
            };
        }

        internal static List<HydrothermalVentLine> ReadHydroventsListPart1()
        {
            var lines = File.ReadAllLines(@".\Day 5\Input\HydrothermalVentList1.txt");

            var hydroventList = new List<HydrothermalVentLine>();
            foreach (var line in lines)
            {
                hydroventList.Add(String2HydroventLine(line));
            }

            return hydroventList;
        }

        private static HydrothermalVentLine String2HydroventLine(string line)
        {
            // extract '->' by splitting on 'space'
            var step1 = line.Trim().Split(' ');

            // extract point from coordinates
            var beginPoint = ExtractPoint(step1[0]);
            var endPoint = ExtractPoint(step1[2]);

            return new HydrothermalVentLine(beginPoint, endPoint);
        }

        private static Point ExtractPoint(string coordinates)
        {
            var coordinatesStringArray = coordinates.Split(',');
            return new Point(int.Parse(coordinatesStringArray[0]), int.Parse(coordinatesStringArray[1]));
        }        
    }
}
