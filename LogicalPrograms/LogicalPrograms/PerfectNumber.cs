using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public void CheckPerfectNumber()
        {
            int num, i,sum=0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Divisors are ");
            for(i=1;i<num;i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }                   
            }
            Console.WriteLine("Sum of divisors is " + sum);
            if(num==sum)
            {
                Console.WriteLine("Perfect number");
            }
            else
            {
                Console.WriteLine("Not a perfect number");
            }
         
        }
    }
}
