using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class ArrayBasics
    {


        public void ArrayBasics1()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };





            int searchElement = 100;
            bool flag = true;


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchElement)
                {
                    Console.WriteLine("Element Found At index " + i);
                    flag = false;
                    break;

                }
            }
            if (flag)
            {
                Console.WriteLine("Not Found");

            }

            Console.WriteLine("Element Found " + Array.IndexOf(arr, 20));
            Console.WriteLine("Element Found " + Array.IndexOf(arr, 100));
            Console.WriteLine("Element Found At " + Array.BinarySearch(arr, 30));


            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");

            }
            Console.WriteLine();

            Array.Clear(arr1, 2, 4);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(arr1.Length);
            Array.Resize(ref arr1, 10);
            Console.WriteLine(arr1.Length);


            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();


            int[] arr2 = { 10, 20, 60, 80, 100, 30, 20 };

            Array.Sort(arr2);

            for(int i = 0;i < arr2.Length;i++)
            {
                Console.Write(arr2[i]+" ");
            }

            Console.WriteLine();
            int[] arr3 = { 10, 20, 60, 80, 100, 30, 20 };


            Array.Reverse(arr3);
            for(int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i]+" ");
            }
            Console.WriteLine();



            int[] arr4 = { 10, 20, 30, 40, 50 };

            int[] arr5 = new int[arr4.Length];



            Array.Copy(arr4,arr5,arr4.Length);

            Console.WriteLine("Array5 Copied elementss ");
            for (int i = 0; i < arr5.Length; i++)
            {
                Console.Write(arr5[i]+" ");
            }
            
            

            int[] arr6 = { 10, 20, 30, 40, 50 };

            int[] arr7 = new int[arr4.Length];

            
            



        }

    }
}
