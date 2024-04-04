using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class MinAndMaxElement
    {

        public void MinAndMaxElement1()
        {
            int[] arr = { 10, 8, 20, 6, 100, 50, 500 };


            int min = arr[0];

            for(int i=0; i<arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];

                }
            }
            Console.WriteLine("Min "+min);



            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];

                }
            }
            Console.WriteLine("Max "+max);

        }
    }
}
