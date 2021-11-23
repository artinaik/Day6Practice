using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace LogicalPrograms
{
    class StopwatchProgram
    {
        public void FindTime()
        {
            Stopwatch stopwatchobj = new Stopwatch();
            Console.WriteLine("Type Start if you have to Start the Stopwatch");
            string start = Console.ReadLine();
            stopwatchobj.Start();
            Console.WriteLine("Type Stop if you have to Start the Stopwatch");
            string stop = Console.ReadLine();
            stopwatchobj.Stop();
            Console.WriteLine("Time elapsed is " + stopwatchobj.Elapsed);
        }
    }
}
