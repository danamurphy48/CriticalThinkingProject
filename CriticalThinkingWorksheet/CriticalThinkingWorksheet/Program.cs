using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheet
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculatorMadness calculator = new CalculatorMadness();
            //calculator.Sum();
            //calculator.AddTwoNumbers(8, 40);
            //calculator.AddTwoNumbers(200, 50);
            //Console.WriteLine(calculator.resultTotal);
            calculator.RunCalculations();


            //WhileLoopFun whileloop = new WhileLoopFun();
            //whileloop.WhileLooper();

            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.Write(i);
            //}
            //Console.ReadLine();


            //ForLoopFun forLoopFun = new ForLoopFun();
            //forLoopFun.LoopString();
            //forLoopFun.LoopUserInput();
            //forLoopFun.HelloWorldLoop("Hello World");

        }
    }
}
