using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class UniqueElements
    {


        public void UniqueElements1() {

            int[] arr = { 1, 1, 2, 23, 4, 5, 5, 6, 6, 7 };

            for(int i = 0; i < arr.Length; i++) {

                int count = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i]== arr[j])
                    {
                        count++;
                    }


                }

                if(count == 1)
                {
                    Console.Write(arr[i]+ "  ");

                }
                
            

            }

        
        }
    }

}
