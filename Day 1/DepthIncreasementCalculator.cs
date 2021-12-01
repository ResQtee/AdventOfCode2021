using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_1
{
    internal class DepthIncreasementCalculator
    {
        public static int CalculateDepthIncreasementsExamplePart1()
        {
            var sonarSweeps = SonarSweepsInputReader.SonarSweepsExample();
            return CalculateDepthIncreasement(sonarSweeps);
        }

        public static int CalculateDepthIncreasementsPart1()
        {
            var sonarSweeps = SonarSweepsInputReader.SonarSweepsPart1();
            return CalculateDepthIncreasement(sonarSweeps);
        }

        public static int CalculateDepthIncreasementsExamplePart2()
        {
            var sonarSweeps = SonarSweepsInputReader.SonarSweepsExample();
            return CalculateDepthIncreasementsSlidingWindow(sonarSweeps, 3);
        }

        public static int CalculateDepthIncreasementsPart2()
        {
            var sonarSweeps = SonarSweepsInputReader.SonarSweepsPart2();
            return CalculateDepthIncreasementsSlidingWindow(sonarSweeps, 3);
        }

        // in essence a sliding window of 1.
        private static int CalculateDepthIncreasement(List<int> sonarSweepDepths)
        {
            int depthIncreasements = 0;
            for (int i = 0; i < sonarSweepDepths.Count() - 1; i++)
            {
                var currentDepth = sonarSweepDepths[i];
                var nextDepth = sonarSweepDepths[i + 1];

                if (HasDepthIncreased(currentDepth, nextDepth))
                {
                    depthIncreasements++;
                }
            }

            return depthIncreasements;
        }

        private static int CalculateDepthIncreasementsSlidingWindow(List<int> sonarSweepDepths, int windowSize)
        {
            int depthIncreasements = 0;
            for (int i = 0; i < sonarSweepDepths.Count() - windowSize; i++)
            {
                var current = sonarSweepDepths.GetRange(i, windowSize).Sum();
                var next = sonarSweepDepths.GetRange(i + 1, windowSize).Sum();

                if (HasDepthIncreased(current, next))
                {
                    depthIncreasements++;
                }
            }

            return depthIncreasements;
        }

        /// <summary>
        /// Returns True when the secondDepth is deeper than the firstDepth.
        /// Higher depth value means deeper.
        /// </summary>        
        private static bool HasDepthIncreased(int firstDepth, int secondDepth) => secondDepth > firstDepth;
    }
}
