using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtended
{
    class Program
    {
        enum Days
        {
            Sat=105,
            Sun,
            Mon=1,
            Tue,
            Wed=2,
            Thurs
        }
        static void Print1DArray(int[] arr)
        {
           /*for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i]+" ");
            }*/         
            foreach (int num in arr) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void Print2DArray(string[,] arr) {
            int r = arr.GetLength(0);
            int c = arr.GetLength(1);
            for (int i = 0; i < r; i++) {
                for (int j = 0; j < c; j++) {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
        static int Sum(params int[] array) {
            int sum = 0;
            foreach (int num in array) {
                sum += num;
            }
            return sum;
        }
        
        static void PrintJaggedArray(int[][] arr) {
            //for (int i = 0; i < arr.Length; i++) {
            //    for (int j = 0; j < arr[i].Length; j++) {
            //        Console.Write(arr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            foreach (int[] inner in arr) {
                foreach (int num in inner) {
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5};
            Print1DArray(arr);
            int[] arr2 = { 3, 45, 656, 687 };
            Print1DArray(arr2);
            string[,] arr3 = {
                {"Karim","Mike" },
                {"Rasel","Robin" },
                {"Manik","Rahat" },
            };
            Print2DArray(arr3);

            int[][] jagged = {
                new int[]{ 1,2,4},
                new int[]{ 2,54,14,14},
                new int[]{ 16,4}
            };
            PrintJaggedArray(jagged);
            Console.WriteLine("**********************");
            Console.WriteLine(Sum());
            Console.WriteLine(Sum(10));
            Console.WriteLine(Sum(10, 12, 34,67,78,54));
            Console.WriteLine(Sum(10,12,34));
            Console.WriteLine(Sum(10, 12));
            Console.WriteLine(Sum(arr));
            Console.WriteLine("**********************");
            Console.WriteLine((Days)105);
        }
    }
}
