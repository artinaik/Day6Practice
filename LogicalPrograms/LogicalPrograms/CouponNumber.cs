using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public void CheckCoupon()
        {
            Console.WriteLine("Enter number for distinct coupon");
            int number = Convert.ToInt32(Console.ReadLine());
            FindCount(number);
        }  
        public void FindCount(int number)
        {
            int num = number;
            int distinct=0, count=0;
            bool[] arr = new bool[num];
            while(distinct<num)
            {
                Random random = new Random();
                int testNumber = random.Next(0, num);
                count++;
                if (!arr[testNumber])
                {
                    distinct++;
                    arr[testNumber] = true;
                }
                else
                {
                    arr[testNumber] = false;
                }
            }
            Console.WriteLine("Total random numbers for distinct coupons is " + count);
        }
    }
}
