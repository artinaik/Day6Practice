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
            Console.WriteLine("\n1)Fibonoccie Series \n2)Perfect Number \n3)Prime Number \n4)Reverse Number \n5)Coupon Number " +
                "\n6)Stopwatch \n7)Notes Problem \n8)Find Day of Week \n9)Temperature Conversion \n10)MonthlyPayment \n11)Sqrt of number" +
                "\n12)Binary Conversion \n13)String replace");
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
                case 9:
                    Util.TemperatureConversion();
                    break;
                case 10:
                    Util.MonthlyPayment();
                    break;
                case 11:
                    Util.Sqrt();
                    break;
                case 12:
                    Util.ToBinary();
                    break;
                case 13:
                    StringReplace stringReplaceobj = new StringReplace();
                    stringReplaceobj.ReplaceTheString();
                        break;
            }
            
            Console.ReadKey();
        }
    }
}
