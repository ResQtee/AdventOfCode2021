using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_11
{
    internal class DumboOctopus
    {
        public int FlashThreshold => 9;
        public int EnergyLevel { get; private set; } = 0;
        public bool Flashed { get; private set; }
        public long FlashCounter { get; private set; }
        public List<DumboOctopus> Neighbours { get; private set; } = new List<DumboOctopus>();

        public DumboOctopus(int energyLevel)
        {
            EnergyLevel = energyLevel;
        }        

        public void IncreaseEnergy()
        {
            if (Flashed) return;

            EnergyLevel++;
            if (EnergyLevel > FlashThreshold)
            {
                Flash();
            }
        }

        public void Flash()
        {
            Flashed = true;;
            FlashCounter++;
            EnergyLevel = 0;

            foreach(var octopus in Neighbours)
            {
                octopus.IncreaseEnergy();
            }
        }

        public void FlashReset()
        {
            Flashed = false;
        }

        public void NextSimulationStep()
        {
            IncreaseEnergy();
        }

        public void AddNeighbour(DumboOctopus neighbour)
        {
            Neighbours.Add(neighbour);
        }
    }
}
