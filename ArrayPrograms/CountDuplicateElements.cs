using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class CountDuplicateElements
    {

        
        public void CountDuplicateElements1() {

            int[] arr = { 1, 1, 2, 3, 2, 4, 5, 5, 6 };

            int duplicateElements = 0;
            for (int i=0;i<arr.Length; i++)
            {
                int count = 0;
              

                for(int j = i; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine(arr[i] + " ");

                    duplicateElements++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Duplicate Elemenst "+ duplicateElements);
        }
    }
}
