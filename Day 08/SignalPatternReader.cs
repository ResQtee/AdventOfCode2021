using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_8
{
    internal class SignalPatternReader
    {
        public List<SignalPattern> ReadSignalPatterns(string file)
        {
            var lines = File.ReadAllLines(file);
            return lines.Select(line => new SignalPattern(line)).ToList();
        }
    }

    public class SignalPattern
    {
        public SignalPattern(string signalPatterns)
        {
            var splittedSignalPattern = signalPatterns.Trim().Split('|');

            Patterns = splittedSignalPattern[0].Trim().Split(' ').Select(pattern => pattern.OrderBy(c => c).ToArray()).ToList();
            DigitalOutput = splittedSignalPattern[1].Trim().Split(' ').Select(pattern => pattern.OrderBy(c => c).ToArray()).ToList();
        }

        public List<char[]> Patterns { get; } = new List<char[]>();
        public List<char[]> DigitalOutput { get; }
    }
}
