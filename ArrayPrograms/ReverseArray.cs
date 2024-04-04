using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class ReverseArray
    {

        public void ReverseArray1() {

            int[] arr = { 2, 5, 7 };


            for(int i=arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i]+" ");
            }



        }
    }
}
