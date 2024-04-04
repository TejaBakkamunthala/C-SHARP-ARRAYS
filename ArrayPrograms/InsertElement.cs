using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    public class InsertElement
    {
        public void InsertElement1()
        {
            List<int> arr =new List<int> { 1, 2, 3,4, 5, 7,8, 9 };

            int insertposition = 5;
            int element = 6;
            arr.Insert(insertposition, element);



            
            //arr[position] = insertElement;
            //var result = arr[position];

            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }

            //Console.WriteLine();
            //Array.IndexOf(arr, insertElement);
            

            //foreach (int i in arr)
            //{
            //    Console.Write(i+" ");
            //}

            //int[] arr1 = new int[arr.Length + 1];

            //for(int i=0;i<arr.Length; i++)
            //{
            //    Console.Write(arr[i]+" ");
            //}

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i + 1;
            //}

            //    Console.WriteLine();

            //    for(int i=0;i<arr.Length;i++)
            //    {

            //        if ( arr[i]<=position)
            //        {
            //            arr1[i] = arr[i];
            //        }

            //        else if (i == position+1)
            //        {
            //            arr1[i] = insertElement;
            //        }
            //        else if (arr[i] > insertElement)
            //        {
            //            arr1[i] = arr[i];
            //        }

            //    }

            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        Console.Write(arr1[i]+ " ");
            //    }
            //}

        }
    }
}
