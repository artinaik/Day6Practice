using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class NoteChange
    {
        public static void CalculateNotes()
        {
            Console.WriteLine("Enter note in Rs. to be returned by vending machine");
            int note = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} =>{1}", arr[i], note / arr[i]);
                note = note % arr[i];
            }
        }
    }
}

