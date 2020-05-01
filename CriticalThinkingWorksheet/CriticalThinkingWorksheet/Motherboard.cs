using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheet
{
    class Motherboard
    {
        //member variables
        public string Manufacturer;
        public CPU Processor;
        public RAM TemporaryMemory;
        public HardDrive Storage;
        public GPU Graphics;
        //constructor
        public Motherboard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;
        }

        //member methods
        public void InstallApplication(Applications applications)
        {
            Storage.ApplicationsInHardDrive = new List<Applications>();
            Storage.ApplicationsInHardDrive.Add(applications);

        }

    }
}
