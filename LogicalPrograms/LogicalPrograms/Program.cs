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
            Console.WriteLine("Logical Programs");
            Fibonoccies fibonocciesobj = new Fibonoccies();
            fibonocciesobj.FindSeries();
            Console.ReadKey();
        }
    }
}
