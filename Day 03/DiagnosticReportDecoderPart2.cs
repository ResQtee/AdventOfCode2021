using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_3
{
    internal class DiagnosticReportDecoderPart2
    {
        public void CalculateLifeSupportRatingExample()
        {
            var oxygenRatingString = FindOxygenRating(DiagnosticReportReader.ReadExampleDiagnosticReport());
            var oxygenRating = Convert.ToInt32(oxygenRatingString, 2);            
                                    
            var co2RatingString = FindCO2Rating(DiagnosticReportReader.ReadExampleDiagnosticReport());
            var co2Rating = Convert.ToInt32(co2RatingString, 2);

            var originalBgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Environment.NewLine}--- Example Part 2 ---");
            Console.ForegroundColor = originalBgColor;
            Console.WriteLine($"Oxygen: {oxygenRatingString} ({oxygenRating})");
            Console.WriteLine($"CO2: {co2RatingString} ({co2Rating})");
            Console.WriteLine($"Life support rating: {oxygenRating*co2Rating}");
        }

        public void CalculateLifeSupportRating()
        {
            var oxygenRatingString = FindOxygenRating(DiagnosticReportReader.ReadSecondDiagnosticReport());
            var oxygenRating = Convert.ToInt32(oxygenRatingString, 2);

            var co2RatingString = FindCO2Rating(DiagnosticReportReader.ReadSecondDiagnosticReport());
            var co2Rating = Convert.ToInt32(co2RatingString, 2);

            var originalBgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Environment.NewLine}--- Part 2 ---");
            Console.ForegroundColor = originalBgColor;
            Console.WriteLine($"Oxygen: {oxygenRatingString} ({oxygenRating})");
            Console.WriteLine($"CO2: {co2RatingString} ({co2Rating})");
            Console.WriteLine($"Life support rating: {oxygenRating * co2Rating}");
        }


        private string FindOxygenRating(List<string> report)
        {
            // Oxygen = most common value at [index] value.
            return Sieve(report, DetermineMajorityAtIndex);
        }

        private string FindCO2Rating(List<string> report)
        {
            // CO2 = least common value at [index] value.
            return Sieve(report, DetermineLeastCommonAtIndex);
        }

        private string Sieve(List<string> report, Func<int, List<string>, char> filter)
        {
            int index = 0;
            while(report.Count > 1)
            {
                var x = filter(index, report);
                report = FilterByCharOnIndex(index, x, report);

                index++;
            }

            return report[0];
        }

        private char DetermineMajorityAtIndex(int index, List<string> report)
        {
            int noOfSamples = report.Count();
            var majority = Math.Ceiling((noOfSamples / 2d) + 1); // only works when noOfSample > 2
            int zeroCounter = 0;
            int oneCounter = 0;
            var sampleCounter = 0;

            while (zeroCounter < majority && oneCounter < majority && sampleCounter < noOfSamples)
            {
                if (report[sampleCounter][index] == '0')
                {
                    zeroCounter++;
                }
                else if (report[sampleCounter][index] == '1')
                {
                    oneCounter++;
                }

                sampleCounter++;
            }

            return zeroCounter > oneCounter ? '0' : '1';
        }

        private char DetermineLeastCommonAtIndex(int index, List<string> report)
        {
            int noOfSamples = report.Count();
            var majority = Math.Ceiling((noOfSamples / 2d) + 1); // only works when noOfSample > 2
            int zeroCounter = 0;
            int oneCounter = 0;
            var sampleCounter = 0;

            while (zeroCounter < majority && oneCounter < majority && sampleCounter < noOfSamples)
            {
                if (report[sampleCounter][index] == '0')
                {
                    zeroCounter++;
                }
                else if (report[sampleCounter][index] == '1')
                {
                    oneCounter++;
                }

                sampleCounter++;
            }

            return zeroCounter > oneCounter ? '1' : '0';
        }

        private List<string> FilterByCharOnIndex(int index, char filter, List<string> report)
        {
            return report.Where(x => x[index] == filter).ToList();
        }
    }
}
