using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Logical Programs");
            Console.WriteLine("1)Fibonoccie Series 2)Perfect Number 3)Prime Number 4)Reverse Number 5)Coupon Number 6)Stopwatch");
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Fibonoccies fibonocciesobj = new Fibonoccies();
                    fibonocciesobj.FindSeries();
                    break;
                case 2:
                    PerfectNumber perfectNumberobj = new PerfectNumber();
                    perfectNumberobj.CheckPerfectNumber();
                    break;
                case 3:
                    PrimeNumber primeNumberobj = new PrimeNumber();
                    primeNumberobj.CheckPrime();
                    break;
                case 4:
                    ReverseNumber reverseNumberobj=new ReverseNumber();
                    reverseNumberobj.FindReverse();
                    break;
                case 5:
                    CouponNumber couponNumberobj = new CouponNumber();
                    couponNumberobj.CheckCoupon();
                    break;
                case 6:
                    StopwatchProgram stopwatchobj = new StopwatchProgram();
                    stopwatchobj.FindTime();
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
