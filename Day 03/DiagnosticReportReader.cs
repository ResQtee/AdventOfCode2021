using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_3
{
    internal class DiagnosticReportReader
    {
        public static List<string> ReadExampleDiagnosticReport()
        {
            return new List<string>
            {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"
            };
        }

        public static List<string> ReadFirstDiagnosticReport()
        {
            return ReadDiagnosticReport(@".\Day 3\Input\DiagnosticReport1.txt");
        }

        public static List<string> ReadSecondDiagnosticReport()
        {
            return ReadDiagnosticReport(@".\Day 3\Input\DiagnosticReport2.txt");
        }

        private static List<string> ReadDiagnosticReport(string file)
        {
            return File.ReadAllLines(file).ToList();
        }
    }
}
