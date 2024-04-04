using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class CopyElements
    {


        public void  CopyElements1() {


            int[] arr= { 1, 2, 3,4,5,6 };

            int[] arr1 = new int[arr.Length];

            int j = 0;
            Console.WriteLine("Copied Elementss ");
            for (int i=0; i<arr.Length; i++)
            {
                arr1[j] = arr[i];
                j++;
            }

            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr1[i]+"  ");
            }



        }


    }
}
