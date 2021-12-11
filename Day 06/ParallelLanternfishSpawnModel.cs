using System.Collections.Concurrent;

namespace AdventOfCode2021.Day_6
{
    public class ParallelLanternfishSpawnModel
    {
        public List<int> State { get; private set; }

        public int Day { get; private set; }

        public int SchoolSize { get { return State.Count; } }

        public ParallelLanternfishSpawnModel(List<int> initialState)
        {
            State = initialState;
            Day = 0;
        }

        public void Forward1Day()
        {
            ConcurrentBag<int> newFish = new ConcurrentBag<int>();
            Parallel.For(0, State.Count, i => 
            {
                if (State[i] == 0)
                {
                    newFish.Add(8);
                    State[i] = 6;
                }
                else
                    State[i]--;
            });            

            State.AddRange(newFish);
            Day++;
        }

        public void ForwardXDays(int days)
        {
            for (int i = 0; i < days; i++)
            {
                Forward1Day();
            }

            Console.WriteLine($"School size: {SchoolSize}");
        }

        private void Print()
        {
            Console.Write($"After {Day} days: ");
            foreach (var fish in State)
            {
                Console.Write($"{fish}, ");
            }
            Console.WriteLine();
        }
    }
}
