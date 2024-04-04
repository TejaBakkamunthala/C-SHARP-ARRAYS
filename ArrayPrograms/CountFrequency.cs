using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class CountFrequency
    {


        public void CountFrequency1()
        {

            int[] arr = { 10, 20, 30, 10, 40, 50, 50, 60, 10, 20, 30 };

            
            for(int i=0;i<arr.Length; i++)
            {
                int frequency = 0;
                for (int j=i;j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {

                        frequency++;
                    }
                }

                if(frequency >= 0)
                {
                    Console.WriteLine("Number " + arr[i]+ "Frequency "+frequency);
                }


            }



        }
    }
}
