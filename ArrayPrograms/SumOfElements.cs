using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class SumOfElements
    {


        public void SumOfElements1()
        {
            int[] arr = { 2, 5, 8 };

            int sum = 0;

            for(int i=0; i<arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine(" Sum"+sum);



        }


       
    }
}
