using System;
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
        public void LoopUserInput()
        {
            
            Console.WriteLine($"Please choose how many times you want to loop");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void HelloWorldLoop()
        {
            string userInput = "Hello World";

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
