using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // matrix 3 hang 2 cot
            /*int[,] arr = new int[3, 2] { {1, 2}, {4, 5 }, { 3, 6} };
            Console.WriteLine(arr[1,1]);*/

            // Khoi tao mang ngau nhien

            // nhap ma tran m*n
            Console.WriteLine("Nhap so dong m: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot n: ");
            int n = int.Parse(Console.ReadLine());
            // khai bao mang
            int[,] arr = new int[m, n];
            // khai bao random
            Random rd = new Random();
            // Sinh cac phan tu trong ma tran random
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rd.Next(100);
                }
            }
            // Hien thi ma tran
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
