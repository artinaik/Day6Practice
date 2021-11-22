using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public void CheckPrime()
        {
            int num,i;
            bool prime=true;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=2;i<=num/2;i++)
            {
                if (num % i == 0)
                    prime = false;
            }
            if(prime==true)
            {
                Console.WriteLine("Number is prime number");
            }
            else
            {
                Console.WriteLine("Number is not a prime number");
            }

        }
    }
}
