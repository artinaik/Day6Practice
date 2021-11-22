using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public void FindReverse()
        {
            int reminder, reverse = 0;
            Console.Write("Enter a Number ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;
            }
            Console.WriteLine("The Reverse number is " + reverse); 
        }
    }
}
