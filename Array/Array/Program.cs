using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dimensional array
            int[] arr1 = new int[5];
            arr1[0] = 1;
            arr1[1] = 45;
            for (int i = 0; i < arr1.Length; i++) {
                arr1[i] = 100 + i;
            }
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int[] arr3 = new int[] { 1, 2, 3, 4, 5, 6};
            int[] arr4 = new int[5] { 1, 2, 3, 4, 5};

            for (int i = 0; i < arr2.Length; i++) {
                Console.WriteLine(arr4[i]+ " ");
            }
            //2 dimensional array
            int[,] arr5 = new int[4, 2];
            arr5[0, 0] = 1;
            arr5[0, 1] = 2;
            int[,] arr6 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 2; j++) {
                    Console.Write(arr6[i,j]+" " );
                }
                Console.WriteLine();
            }
            //jagged array
            int[][] arr7 = new int[3][];
            arr7[0] = new int[5];
            arr7[1] = new int[3];
            arr7[2] = new int[2];

            arr7[0][3] = 123;
            

            int[][] arr8 = {
                new int [5],
                new int [3],
                new int [2]
            };
            int[][] arr9 = {
                new int[] { 1,2,3,4},
                new int[] { 1,2,3},
                new int[] { 1,2,3,4,5,6,7}

            };
            for (int i = 0; i < arr9.Length; i++) {
                for (int j = 0; j < arr9[i].Length; j++) {
                    Console.Write(arr9[i][j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
