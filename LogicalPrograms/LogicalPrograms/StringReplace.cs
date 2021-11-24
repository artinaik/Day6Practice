using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class StringReplace
    {
        public void ReplaceTheString()
        {
            string msg,msg1;
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            if (name.Length >= 3)
            {
                msg = "Hello <<username>> How are you";
                msg1=msg.Replace("username", name);
                Console.WriteLine(msg1);
            }
            else
            {
                Console.WriteLine("Please enter more than 3 characters");
            }
        }
    }
}
