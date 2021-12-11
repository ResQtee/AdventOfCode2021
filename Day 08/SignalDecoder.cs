using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_8
{
    internal class SignalDecoder
    {
        /*
        0:      1:      2:      3:      4:
       aaaa    ....    aaaa    aaaa    ....
      b    c  .    c  .    c  .    c  b    c
      b    c  .    c  .    c  .    c  b    c
       ....    ....    dddd    dddd    dddd
      e    f  .    f  e    .  .    f  .    f
      e    f  .    f  e    .  .    f  .    f
       gggg    ....    gggg    gggg    ....

        5:      6:      7:      8:      9:
       aaaa    aaaa    aaaa    aaaa    aaaa
      b    .  b    .  .    c  b    c  b    c
      b    .  b    .  .    c  b    c  b    c
       dddd    dddd    ....    dddd    dddd
      .    f  e    f  .    f  e    f  .    f
      .    f  e    f  .    f  e    f  .    f
       gggg    gggg    ....    gggg    gggg
        */
        private string zero = "abcefg";     // 0
        private string one = "cf";          // 1
        private string two = "acdeg";       // 2
        private string three = "acdfg";     // 3
        private string four = "bcdf";       // 4
        private string five = "abdfg";      // 5
        private string six = "abdefg";      // 6
        private string seven = "acf";       // 7
        private string eight = "abcdefg";   // 8
        private string nine = "abcdfg";     // 9

        /*
        1,4,7,8
        a, cf rechts, bd linksboven midden

        2 is enige zonder f

        0,6,9 = 1 minder dan 8; (c,d,e)
        2,3,5 = 2 minder dan 8 (5 heeft b, 2 heeft e, )
        

        0,2,3,5,6,9

        
        a = 7-1
        b = 9-3 
        d = 8-0
        e = 6-5 (6=1 letter meer dan 5)
        e = 8-9 (8 = 1 letter meer dan 9)
        c = 8-6 (8= 1 letter meer dan 6)
        
        6,9,3 hebben 1 segment minder dan 8.

        als je a weet, dan is g = 9-4
        als je a en g weet dan weet je wat 0 is.


        

1,4,7,8 op basis van string length
2 (enige van alle  die geen common segment heeft van string length 5)
3 (common segment wel in 3 niet in 2, dus plaats f)
5

acedgfb cdfbe gcdfa fbcad dab cefabd cdfgeb eafb cagedb ab | cdfeb fcadb cdfeb cdbaf

ab = 1
dab = 7
eafb = 4
acedgfb = 8

gcdfa = 2 

        */

        public void Decode(SignalPattern signalPattern)
        {
            Dictionary<char[], int> decoded = new Dictionary<char[], int>();
            var unknownSignals = new List<char[]>(signalPattern.Patterns);

            foreach (var signal in unknownSignals)
            {
                if(signal.Length == 2)
                {
                    decoded.Add(signal, 1);
                }

                if (signal.Length == 4)
                {
                    decoded.Add(signal, 4);
                }

                if (signal.Length == 3)
                {
                    decoded.Add(signal, 7);
                }

                if (signal.Length == 7)
                {
                    decoded.Add(signal, 8);
                }
            }
            unknownSignals.RemoveAll(x => decoded.ContainsKey(x));

            Determine2(unknownSignals);
        }

        private char[] Determine2(List<char[]> signals)
        {
            var fiveSegments = signals.Where(s => s.Length == 5).ToList();

            
            int aCount = Count('a', fiveSegments);
            int bCount = Count('b', fiveSegments); ;
            int cCount = Count('c', fiveSegments);;
            int dCount = Count('d', fiveSegments);;
            int eCount = Count('e', fiveSegments);;
            int fCount = Count('f', fiveSegments);;
            int gCount = Count('g', fiveSegments); ;

            return fiveSegments[0];
        }

        private int Count(char v, List<char[]> fiveSegments)
        {
            var total = 0;
            
            foreach (var segment in fiveSegments)
            {
                total += segment.Count(c => c==v);
            }

            return total;
        }

        public int Count1478(List<SignalPattern> signals)
        {
            var ones = CountOnes(signals);
            var fours = CountFour(signals);
            var sevens = CountSevens(signals);
            var eigths = CountEights(signals);

            return ones + fours + sevens + eigths;
        }

        public int CountOnes(List<SignalPattern> signalPatterns)
        {
            int oneCount = 0;
            foreach (var signalPattern in signalPatterns)
            {
                oneCount += signalPattern.DigitalOutput.Count(pattern => pattern.Length == 2);
            }

            return oneCount;
        }

        public int CountFour(List<SignalPattern> signalPatterns)
        {
            int fourCount = 0;
            foreach (var signalPattern in signalPatterns)
            {
                fourCount += signalPattern.DigitalOutput.Count(pattern => pattern.Length == 4);
            }

            return fourCount;
        }

        public int CountSevens(List<SignalPattern> signalPatterns)
        {
            int sevenCount = 0;
            foreach (var signalPattern in signalPatterns)
            {
                sevenCount += signalPattern.DigitalOutput.Count(pattern => pattern.Length == 3);
            }

            return sevenCount;
        }

        public int CountEights(List<SignalPattern> signalPatterns)
        {
            int eightCount = 0;
            foreach (var signalPattern in signalPatterns)
            {
                eightCount += signalPattern.DigitalOutput.Count(pattern => pattern.Length == 7);
            }

            return eightCount;
        }
    }
}
