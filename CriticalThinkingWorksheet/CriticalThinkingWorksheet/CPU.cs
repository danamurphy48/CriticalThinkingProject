using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheet
{
    class CPU
    {
        //member variables
        public string Manufacturer;
        public string Name;
        //constructor
        public CPU(string manufacturer, string name)
        {
            Manufacturer = manufacturer;
            Name = name;
        }
        //member methods
        public void ProcessInstall(Games games, Motherboard motherboard)
        {
            motherboard.Storage.ApplicationsInHardDrive = new List<Applications>();
            motherboard.Storage.ApplicationsInHardDrive.Add(games);
            motherboard.Storage.TotalStorage = motherboard.Storage.AvailableStorage - games.RequiredStorage;
            motherboard.TemporaryMemory.TotalGigabites -= games.RequiredRAM;
            motherboard.Graphics.EffectiveMemory -= games.RequiredEffectiveMemory;
        }
        public bool CheckRequirements(Games games, Motherboard motherboard)
        {
            bool meetsRequirements = false;
            while (!meetsRequirements)
            {
                if ((motherboard.TemporaryMemory.TotalGigabites < games.RequiredRAM) || (motherboard.Storage.AvailableStorage < games.RequiredStorage) || (games.RequiredEffectiveMemory > motherboard.Graphics.EffectiveMemory))
                {
                    meetsRequirements = false;
                }
                else
                {
                    ProcessInstall(games, motherboard);
                    meetsRequirements = true;
                }
            }
            return meetsRequirements;
        }
    }
}