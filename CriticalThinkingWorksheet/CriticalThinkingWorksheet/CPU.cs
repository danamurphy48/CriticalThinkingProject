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
        public void ProcessInstall(Applications applications, HardDrive hardDrive, RAM ram, Games games, GPU gpu)
        {
            hardDrive.ApplicationsInHardDrive = new List<Applications>();
            hardDrive.ApplicationsInHardDrive.Add(applications);
            hardDrive.TotalStorage = hardDrive.AvailableStorage - applications.RequiredStorage;
            ram.TotalGigabites -= applications.RequiredRAM;
            gpu.EffectiveMemory -= games.RequiredEffectiveMemory;
        }
        public bool CheckRequirements(Applications applications, HardDrive hardDrive, RAM ram, Games games, GPU gpu)
        {
            bool meetsRequirements = false;
            while (!meetsRequirements)
            {
                if ((ram.TotalGigabites < applications.RequiredRAM) || (hardDrive.AvailableStorage < applications.RequiredStorage) || (games.RequiredEffectiveMemory > gpu.EffectiveMemory))
                {
                    meetsRequirements = false;
                    //return false;
                }
                else
                {
                    ProcessInstall(applications, hardDrive, ram, games, gpu);
                    meetsRequirements = true;
                    //return true;
                }
            }   return meetsRequirements;
        }
    }
}
