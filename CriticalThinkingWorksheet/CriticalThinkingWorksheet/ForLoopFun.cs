﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheet
{
    class ForLoopFun
    {
        //member variables

        //constructor

        //member methods
        public void LoopString()
        {
            string userInput;
            Console.WriteLine($"Please choose a word to loop");
            userInput = Console.ReadLine();
            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine(userInput[i]);
            }


        }


    }
}
