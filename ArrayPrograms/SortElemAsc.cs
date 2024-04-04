using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class SortElemAsc
    {


        public void SortEleAsc1()
        {
            int[] arr1 = { 30, 40, 20, 10, 5, 0, 6, 7 };


            int temp;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;

                    }
                }
            }

           

            for(int i=0;i< arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]+"  ");
            }
        }
    }
}
