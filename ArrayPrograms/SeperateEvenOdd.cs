using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class SeperateEvenOdd
    {

        public void SeperateEvenOdd1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("The Even Elements are ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i] + " ");
                }

            }
            Console.WriteLine("Odd Elements are ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            
            }
        }
    }
}
