using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_6
{
    internal class GroupedLanternfishModel
    {
        public void ForwardXDays(int noOfDays, List<int> initialState)
        {
            var groups = new Dictionary<long, long>(9);
            for (int i = 0; i < 9; i++)
            {
                groups.Add(i, initialState.Count(x => x == i));
            }

            for (int i = 0; i < noOfDays; i++)
            {
                groups = Forward1Day(groups);
            }

            var count = groups.Values.Sum();
            Console.WriteLine($"{count} lanternfish after {noOfDays} days.");
        }

        private Dictionary<long, long> Forward1Day(Dictionary<long,long> groupedFish)
        {
            var newGroups = new Dictionary<long, long>(9);
            for (int i = 8;i >= 0;i--)
            {
                if (i == 0)
                {
                    newGroups[6] += groupedFish[0];
                    newGroups[8] = groupedFish[0];
                }
                else
                {
                    newGroups[i - 1] = groupedFish[i];
                }
            }

            return newGroups;
        }
    }
}
