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
        //public int resultTotal;
        //public int result;

        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
            //int result = numberOne + numberTwo;
            //return result;
        }
        //public void Sum()
        //{
        //    int firstResult = AddTwoNumbers(40, 8);
        //    int secondResult = AddTwoNumbers(200, 50);
        //    int sum = firstResult + secondResult;
        //}
        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }
        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }
        public void RunCalculations()
        {

            //Console.WriteLine("Please enter the first number:");
            //int value1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter the second number:");
            //int value2 = int.Parse(Console.ReadLine());
            //int output = AddTwoNumbers(value1, value2);
            //Console.WriteLine("The result is: " + output);
            ///////////////////////////////////////////////////
            //i.	6 + 5 - ((40*35)/4) + 2^2 
            //output should be -335

            int value1 = 6;
            int value2 = 5;
            int value3 = -40;
            int value4 = 35;
            int value5 = 4;
            int value6 = 2;
            int value7 = 2;

            int output1 = MultiplyTwoNumbers(value6, value7);
            int output2 = MultiplyTwoNumbers(value3, value4);
            int output3 = DivideTwoNumbers(output2, value5);
            int output4 = AddTwoNumbers(value1, value2);
            int output5 = AddTwoNumbers(output4, output3);
            int output6 = AddTwoNumbers(output1, output5);
            Console.WriteLine("The result is: " + output6);

        }

        //public void CalculateTotal(int result)//don't know why this doesn't work
        //{
        //    resultTotal += result;
        //}
    }
}