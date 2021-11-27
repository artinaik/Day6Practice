using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class DecimalToBinary
    {
        public static void FindDecimalToBinary()
        {
            Console.WriteLine("Enter the Decimal Number : ");
            int number = int.Parse(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }

        }
        public static void FindBinaryToDecimal()
        {
            Console.WriteLine("\nEnter the Binary Number");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write("Decimal Value : "+decimalValue);
        }
    }
}
