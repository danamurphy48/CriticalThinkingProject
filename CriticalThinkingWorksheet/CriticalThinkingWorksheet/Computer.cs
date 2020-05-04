using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheet
{
    class Computer
    {
        //member variables
        public CPU Processor;
        public HardDrive Storage;
        public RAM TemporaryMemory;
        public Games games;
        public GPU Graphics;
        public Motherboard motherboard;
        public Applications Application;
        public string Manufacturer;


        //constructor
        public Computer()
        {
            Processor = new CPU("ryzen", "my cpu");
            Storage = new HardDrive(1000, 700);
            TemporaryMemory = new RAM(32, "Corsair");
            games = new Games();
            Graphics = new GPU("MSI", 16);
            motherboard = new Motherboard("MSI", TemporaryMemory, Processor, Storage, Graphics, Application);
        }
        //member methods
        public void BuildComputer()
        {
            Processor.CheckRequirements(games, motherboard);
            Processor.ProcessInstall(games, motherboard);
        }
    }
}
////member variables
//public CPU cpu;
////public HardDrive hardDrive;
////public RAM ram;
////public Games games;
////public GPU gpu;
////constructor
//public Computer(/*CPU cpu, HardDrive hardDrive, RAM ram, Games games, GPU gpu*/)
//{
//    cpu = new CPU("ryzen", "my cpu");
//    //hardDrive = new HardDrive(1000, 700);
//    //ram = new RAM(32, "Corsair");
//    //games = new Games();
//    //gpu = new GPU("MSI", 16);
//}
////member methods
//public void BuildComputer(Games games, Motherboard motherboard)
//{
//    cpu.CheckRequirements(games, motherboard);
//    cpu.ProcessInstall(games, motherboard);
//}
////public void BuildComputer(HardDrive hardDrive, RAM ram, Games games, GPU gpu)
////{
////    cpu.CheckRequirements(hardDrive, ram, games, gpu);
////    cpu.ProcessInstall(hardDrive, ram, games, gpu);
////}
