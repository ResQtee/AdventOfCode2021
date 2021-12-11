using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_3
{
    internal class DiagnosticReportDecoderPart1
    {
        public void DecodeExample()
        {
            var diagnosticReport = DiagnosticReportReader.ReadExampleDiagnosticReport();
            var (gammaRateString, epsilonRateString) = Decode(diagnosticReport);
            var gammaRate = Convert.ToInt32(gammaRateString, 2);
            var epsilonRate = Convert.ToInt32(epsilonRateString, 2);
            
            var originalBgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Environment.NewLine}--- Example Part 1 ---");
            Console.ForegroundColor = originalBgColor;
            Console.WriteLine($"Gamma rate: {gammaRateString} ({gammaRate})");
            Console.WriteLine($"Epsilon rate: {epsilonRateString} ({epsilonRate})");
            Console.WriteLine($"Power consumption: {gammaRate*epsilonRate}");
        }

        public void DecodePart1()
        {
            var diagnosticReport = DiagnosticReportReader.ReadFirstDiagnosticReport();
            var (gammaRateString, epsilonRateString) = Decode(diagnosticReport);
            var gammaRate = Convert.ToInt32(gammaRateString, 2);
            var epsilonRate = Convert.ToInt32(epsilonRateString, 2);
            
            var originalBgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Environment.NewLine}--- Part 1 ---");
            Console.ForegroundColor = originalBgColor;
            Console.WriteLine($"Gamma rate: {gammaRateString} ({gammaRate})");
            Console.WriteLine($"Epsilon rate: {epsilonRateString} ({epsilonRate})");
            Console.WriteLine($"Power consumption: {gammaRate * epsilonRate}");
        }

        private (string gammaRate, string epsilonRate) Decode(List<string> diagnosticReport)
        {
            int noOfDigits = diagnosticReport[0].Length;
            int noOfSamples = diagnosticReport.Count();
            char[] gammaRate = new char[noOfDigits];
            char[] epsilonRate = new char[noOfDigits];
            // Majority rules, so determine what the majority is.
            var majority = Math.Ceiling((noOfSamples / 2d) + 1);
                        
            for (int i = 0; i < noOfDigits; i++)
            {
                int zeroCounter = 0;
                int oneCounter = 0;
                var sampleCounter = 0;

                while (zeroCounter < majority && oneCounter < majority)
                {
                    if (diagnosticReport[sampleCounter][i] == '0')
                    {
                        zeroCounter++;
                    }
                    else if (diagnosticReport[sampleCounter][i] == '1')
                    {
                        oneCounter++;
                    }

                    sampleCounter++;
                }

                if (zeroCounter > oneCounter)
                {
                    gammaRate[i] = '0';
                    epsilonRate[i] = '1';
                }
                else
                {
                    gammaRate[i] = '1';
                    epsilonRate[i] = '0';
                }
            }

            return (new string(gammaRate), new string(epsilonRate));
        }
    }
}
