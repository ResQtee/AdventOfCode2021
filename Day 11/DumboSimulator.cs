using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_11
{
    internal class DumboSimulator
    {
        public long Simulate(DumboOctopus[,] map, int steps)
        {
            List<DumboOctopus> dumbos = MapToList(map);
            PrintMap(map);

            for (int simulationIndex = 0; simulationIndex < steps; simulationIndex++)
            {
                foreach (var dumboOctopus in dumbos)
                {
                    dumboOctopus.NextSimulationStep();
                }

                foreach (var dumboOctopus in dumbos)
                {
                    dumboOctopus.FlashReset();
                }
                //Console.WriteLine($"Step: {simulationIndex+1}");
                //PrintMap(map);
            }

            var totalFlashes = dumbos.Sum(octopus => octopus.FlashCounter);
            Console.WriteLine($"Flashes: {totalFlashes}");
            return totalFlashes;
        }

        public long SynchronizedFlashCounter(DumboOctopus[,] map)
        {
            List<DumboOctopus> dumbos = MapToList(map);
            PrintMap(map);
            long step = 0;
            while(dumbos.Any(octopus => !octopus.Flashed))
            {
                foreach (var dumboOctopus in dumbos)
                {
                    dumboOctopus.FlashReset();
                }

                foreach (var dumboOctopus in dumbos)
                {
                    dumboOctopus.NextSimulationStep();
                }                
                //Console.WriteLine($"Step: {simulationIndex+1}");
                //PrintMap(map);
                step++;
            }
                       
            return step;
        }

        public void PrintMap(DumboOctopus[,] map)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    if(map[x, y].EnergyLevel == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }                    
                    Console.Write($"{map[x, y].EnergyLevel}");
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
        }

        /// <summary>
        /// This creates a list of DumboOctopus including their neighbours.
        /// </summary>
        /// <param name="map">puzzle input</param>
        /// <returns>All the dumbos.</returns>
        public List<DumboOctopus> MapToList(DumboOctopus[,] map)
        {
            var dumbos = new List<DumboOctopus>();
            var Heights = map;

            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    var dumboOctopus = map[x, y];

                    // Left Top 
                    if (x > 0 && y > 0)
                    {
                        dumboOctopus.AddNeighbour(map[x - 1, y - 1]);
                    }

                    // Top
                    if (y > 0)
                    {
                        dumboOctopus.AddNeighbour(map[x, y - 1]);
                    }

                    // Right Top
                    if (x < map.GetLength(0) - 1 && y > 0)
                    {
                        dumboOctopus.AddNeighbour(map[x + 1, y - 1]);
                    }

                    // Left
                    if (x > 0)
                    {
                        dumboOctopus.AddNeighbour(map[x - 1, y]);
                    }

                    // Right
                    if (x < map.GetLength(0) - 1)
                    {
                        dumboOctopus.AddNeighbour(map[x + 1, y]);
                    }

                    // Left Bottom
                    if (x > 0 && y < map.GetLength(1) - 1)
                    {
                        dumboOctopus.AddNeighbour(map[x - 1, y + 1]);
                    }

                    // Bottom
                    if (y < map.GetLength(1) - 1)
                    {
                        dumboOctopus.AddNeighbour(map[x, y + 1]);
                    }

                    // Right Bottom
                    if (x < map.GetLength(0) - 1 && y < map.GetLength(1) - 1)
                    {
                        dumboOctopus.AddNeighbour(map[x + 1, y + 1]);
                    }

                    dumbos.Add(dumboOctopus);
                }
            }

            return dumbos;
        }

        public void NeighboursTest()
        {
            /*
             * 
             * (X-1,Y-1)     (X,Y-1)     (X+1,Y-1)
             * 
             * (X-1,Y)       (X,Y)       (X+1,Y)
             * 
             * (X-1,Y+1)    (X,Y+1)     (X+1,Y+1)
             * 
             */
            int[,] map = new int[3, 3];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"({x},{y})");
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("Has Top Left");
                    }

                    if (y > 0)
                    {
                        Console.WriteLine("Has Top");
                    }

                    if (x < map.GetLength(0) - 1 && y > 0)
                    {
                        Console.WriteLine("Has Top Right");
                    }

                    if (x > 0)
                    {
                        Console.WriteLine("Has Left");
                    }

                    if (x < map.GetLength(0) - 1)
                    {
                        Console.WriteLine("Has Right");
                    }

                    if (x > 0 && y < map.GetLength(1) - 1)
                    {
                        Console.WriteLine("Has Bottom Left");
                    }

                    if (y < map.GetLength(1) - 1)
                    {
                        Console.WriteLine("Has Bottom");
                    }

                    if (x < map.GetLength(0) - 1 && y < map.GetLength(1) - 1)
                    {
                        Console.WriteLine("Has Bottom Right");
                    }
                }
            }
        }
    }
}
