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
            Console.WriteLine($"Please choose how many times you want to loop");
            int counter = int.Parse(Console.ReadLine());

            while (counter < 25)
            {
                counter++;
            }
        }
        
    }
}
