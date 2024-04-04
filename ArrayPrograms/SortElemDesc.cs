using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class SortElemDesc
    {

        public void SortElemDesc1()
        {

            int[] arr1 = { 20, 30, 40, 1, 2, 3, 4, 7, 0, 89, 50 };

            for(int i=0;i<arr1.Length; i++)
            {
                Console.Write(arr1[i]+" ");
            }
            Console.WriteLine();
            int temp;
            for(int i=0;i<arr1.Length; i++)
            {
                for(int j = i; j < arr1.Length; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;

                    }
                }
            }

            for(int i=0;i<arr1.Length;i++)
            {
                Console.Write(arr1[i]+" ");
            }


        }
    }
}
