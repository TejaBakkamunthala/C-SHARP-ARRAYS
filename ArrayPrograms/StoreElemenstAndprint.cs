using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class StoreElemenstAndprint
    {


        public void StoreElemenstAndprint1()
        {
            // int[] arr = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, };


            int[] arr = new int[10];

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] =Convert.ToInt32(Console.ReadLine());
            }


            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
