using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Fibonoccies
    {
        public void FindSeries()
        {
            int firstNum = 0, secondNum = 1, nextNum = 0, i;
            Console.WriteLine("Enter number of series");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(firstNum);
            Console.Write("+"+secondNum);
            for (i = 2; i <num; i++)
            {
                nextNum = firstNum + secondNum;
                Console.Write("+"+nextNum);
                firstNum = secondNum;
                secondNum = nextNum;
            }
        }
    }
}
