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
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void HelloWorldLoop(string userInput)
        {
            string word = "";

            for (int i = word.Length; i < userInput.Length; i++)
            {
                if (i%3 ==0)
                {
                    Console.WriteLine(userInput[i]);
                }
            }
        }

    }
}
