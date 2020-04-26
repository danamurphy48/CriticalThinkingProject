using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheet
{
    class WhileLoopFun
    {
        //member variables
        
        //constructor

        //member methods
        public void WhileLooper()
        {
            //Console.WriteLine($"Please enter the number 42.");
            //int counter = int.Parse(Console.ReadLine());
            //if (counter != 42)
            //{
            //    Console.WriteLine("Please enter the number 42.");
            //    counter = int.Parse(Console.ReadLine());
            //}
            //else
            //{
            //    while (counter != 42)
            //        {
            //            counter++;
            //        }
            //}
            int counter;
            do
            {
                Console.WriteLine("Please enter the number 42.");
                counter = int.Parse(Console.ReadLine());
            }
            while (counter != 42);
            {
                counter++;
            }
        }
        
    }
}
