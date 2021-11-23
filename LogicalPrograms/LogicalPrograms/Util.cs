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
        public static void MonthlyPayment()
        {
            double principal,year,rate;
            Console.WriteLine("Enter Principal loan amount ");
            principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter numbers of how many years want to pay amount");
            year = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate of interest ");
            rate = Convert.ToDouble(Console.ReadLine());
            double r = rate / (12 * 100);
            double n = 12 * year;
            double payment = (principal * r) / (1 - (Math.Pow((1 + r), -n)));
            Console.WriteLine("Monthly Payment is " + payment);

        }
        public static void Sqrt()
        {
            double num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            double t = num;
            while((Math.Abs(t - (num / t)) > (double.Epsilon * t)))
            {
                t = ((num / t)+t)/2;
            }
            Console.WriteLine(t);
          
        }
    }
}
