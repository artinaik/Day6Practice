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
        public static void TemperatureConversion()
        {
            int choice = 0;
            double celsius, fahrenheit;
            Console.WriteLine("1)Celsius to Fahrenheit \n2)Fahrenheit to Celsius");
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter value in Celsious");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    fahrenheit=(celsius * 9/5) + 32;
                    Console.WriteLine("Fahrenheit value is " + fahrenheit);
                    break;
                case 2:
                    Console.WriteLine("Enter value in fahrenheit");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit-32)*5/9;
                    Console.WriteLine("Celsius value is " + celsius);
                    break;
                    
            }


        }
    }
}
