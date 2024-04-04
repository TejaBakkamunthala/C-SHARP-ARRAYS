using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class MultiDimAndJaggedArrays
    {

        public void MultiDimAndJaggedArrays1() {

            int[,] arr = new int[4, 4] { { 1,2,3,4}, {1,2,3,4 }, {1,2,3,4 }, {1,2,3,4 } };

            //for(int i=0; i<arr.GetLength(0); i++)
            //{
            //    for(int j=0; j<arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = Convert.ToInt32(arr[i,j]);
            //    }
            //}

            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();

            }

            Console.WriteLine();


            int[,,] arr1 = new int[2, 2, 2] { { { 1,2},{ 1,2} },{ {1,2 },{1,2 } } };

            for(int i=0; i < arr1.GetLength(0); i++)
            {
                for(int j=0;j<arr1.GetLength(1); j++)
                {
                    for(int k = 0; k < arr1.GetLength(2); k++)
                    {
                        Console.Write(arr1[i,j,k]+"  ");
                    }

                    Console.WriteLine();

                }

                Console.WriteLine();
            }





            Console.WriteLine();

            int[][] arr2 = new int[4][];

            arr2[0] = new int[4] { 1, 2, 3, 4 };
            arr2[1] = new int[3] { 1, 2, 3 };
            arr2[2] = new int[2] { 1, 2 };
            arr2[3] = new int[1] { 1 };

            for(int i=0;i<arr2.Length; i++)
            {
                for(int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j]+" ");
                }
                Console.WriteLine();
            }


        }
    }
}
