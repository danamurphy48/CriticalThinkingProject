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
        //public void ProcessInstall(HardDrive hardDrive, RAM ram, Games games, GPU gpu)
        //{
        //    hardDrive.ApplicationsInHardDrive = new List<Applications>();
        //    hardDrive.ApplicationsInHardDrive.Add(games);
        //    hardDrive.TotalStorage = hardDrive.AvailableStorage - games.RequiredStorage;
        //    ram.TotalGigabites -= games.RequiredRAM;
        //    gpu.EffectiveMemory -= games.RequiredEffectiveMemory;
        //}
        //public bool CheckRequirements(HardDrive hardDrive, RAM ram, Games games, GPU gpu)
        //{
        //    bool meetsRequirements = false;
        //    while (!meetsRequirements)
        //    {
        //        if ((ram.TotalGigabites < games.RequiredRAM) || (hardDrive.AvailableStorage < games.RequiredStorage) || (games.RequiredEffectiveMemory > gpu.EffectiveMemory))
        //        {
        //            meetsRequirements = false;
        //            //return false;
        //        }
        //        else
        //        {
        //            ProcessInstall(hardDrive, ram, games, gpu);
        //            meetsRequirements = true;
        //            //return true;
        //        }
        //    }   return meetsRequirements;
        //}