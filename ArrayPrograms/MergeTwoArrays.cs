using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class MergeTwoArrays
    {
        public void MergeTwoArrays1()
        {

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 6, 5, 4 };

            int[] arr3 = new int[arr1.Length + arr2.Length];

            for(int i=0;i<arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]+" ");
            }

            Console.WriteLine();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for(int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]+" ");
            }


            for(int i=0;i< arr2.Length; i++)
            {
                arr3[arr1.Length+i] = arr2[i];
            }


            for(int i=0;i<arr3.Length; i++)
            {
                Console.Write(arr3[i]+"  ");
            }

            //Console.WriteLine();
            //Array.Sort(arr3);

            //for(int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i] +" ");
            //}

            // 1 2 3 6 5 4
            int temp;

            for(int i=0;i<arr3.Length; i++)
            {
                for(int j=i;j<arr3.Length; j++)
                {
                    if (arr3[i] > arr3[j])
                    {
                        temp = arr3[i];
                        arr3[i] = arr3[j];
                        arr3[j] = temp;

                    }

                }
            }

            Console.WriteLine();

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i]+" ");
            }

        }


    }
}
