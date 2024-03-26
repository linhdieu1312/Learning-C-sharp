using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// khoi tao mang
            int[] arr = new int[10];
            // khai bao mang
            char[] ch;
            // khoi tao mang
            ch = new char[10];
            foreach (int c in arr)
            {
                Console.Write(c + " ");
            } 
            Console.WriteLine();
            // khoi tao va gan gia tri cho mang
            int[] a = new int[4] {1, 3, 5, 7};
            foreach (int c in a)
            {
                Console.Write(c + " ");
            }*/
            Random rd = new Random();
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[n];
            for (int i = 0; i < n; i++)
            {
                ints[i] = rd.Next(1,100);
            }
            Console.WriteLine("Mang co {0} so ngau nhien la :", n);
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Dao nguoc mang: Array.Reverse(mang_muon_dao)
            Array.Reverse(ints);
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Sap xep mang tang dan: Array.Sort(ten mang)
            Array.Sort(ints);
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // Tim kiem 1 so co trong 1 mang ko: su dung BinarySearch:
            // BinarySearch chi su dung duoc voi mang da duoc sap xep Sort
            // ket qua neu k tim dc thi tra ve kqua <= -1, neu tim duoc thi tra ve index cua so do trong mang
            Console.WriteLine("Nhap vao so muon tim: ");
            int x = int.Parse(Console.ReadLine());
            int vtri = Array.BinarySearch(ints, x);
            if (vtri <= -1)
            {
                Console.WriteLine("Khong tim duoc {0} trong mang", x) ;
            }
            else
            {
                Console.WriteLine(x + " o vi tri la " + vtri);
            }
            

            Console.ReadKey();

        }
    }
}
