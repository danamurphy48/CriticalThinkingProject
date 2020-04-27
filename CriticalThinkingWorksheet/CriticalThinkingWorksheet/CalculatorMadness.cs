using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheet
{
    class CalculatorMadness
    {
        //member variables
        public int resultTotal;



        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            //Console.WriteLine(result);
            //return result;
            return numberOne + numberTwo;
            
        }
        public void Sum()
        {
            int firstResult = AddTwoNumbers(40, 8);
            int secondResult = AddTwoNumbers(200, 50);
            int sum = firstResult + secondResult;
        }

        public void RunCalculations()
        {
            
            Console.WriteLine("Please enter the first number:");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int value2 = int.Parse(Console.ReadLine());
            int output = AddTwoNumbers(value1, value2);
            Console.WriteLine("The result is: " + output);
        }

        public void CalculateTotal(int result)
        {
            resultTotal += result;
        }
    }
}