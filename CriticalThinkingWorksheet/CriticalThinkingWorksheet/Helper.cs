using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheet
{
    public static class Helper
    {
        public static string GetUserInput(string output)
        {
            Console.WriteLine(output);
            return Console.ReadLine();
        }

        public static int GetRandomNumber(int min, int max, Random random)
        {
            return random.Next(min, max);
        }
    }
}
