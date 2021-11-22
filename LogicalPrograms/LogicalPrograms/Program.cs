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
            Console.WriteLine("1)Fibonoccie Series 2)Perfect Number");
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
            }
            
            Console.ReadKey();
        }
    }
}
