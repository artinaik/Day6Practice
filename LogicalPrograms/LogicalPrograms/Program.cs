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
            Console.WriteLine("\n1)Fibonoccie Series \n2)Perfect Number \n3)Prime Number \n4)Reverse Number \n5)Coupon Number \n6)Stopwatch \n7)Notes Problem \n8)Find Day of Week");
            Console.WriteLine("\nEnter your choice");
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
                case 7:
                    NoteChange noteChangeobj = new NoteChange();
                    noteChangeobj.CalculateNotes();
                    break;
                case 8:
                    Util.FindDayOfWeek();
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
