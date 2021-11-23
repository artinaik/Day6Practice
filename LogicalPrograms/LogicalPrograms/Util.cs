using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Util
    {
        public static void FindDayOfWeek()
        {
            Console.WriteLine("Enter day of Date between 1 to 31");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month of Date between 1 to 12");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter four digit year");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime dateTime = new DateTime(year,month,day);
            Console.WriteLine("Day of week is " + dateTime.DayOfWeek);
        }
    }
}
