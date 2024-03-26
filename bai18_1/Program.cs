using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// bai 24: tao 1 list co n phan tu, cac phan tu dc lay ngau nhien tu 1-> 100
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            // lay ngau nhien n phan tu va them vao list
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(1, 101);
                list.Add(x);
            }
            Console.WriteLine(list.ToArray());
            Console.WriteLine("List co {0} phan tu ngau nhien la: ", n);
            foreach (int x in list)
            {
                Console.Write(x + " ");
            }*/

            /*//bai 25: nhap 1 list, tao list2 la binh phuong cac phan tu, dem so phan tu > 50
            Console.WriteLine("Nhap n phan tu: ");
            int n = int.Parse(Console.ReadLine());
            // kbao bien dem
            int dem = 0;
            // khoi tao list rong
            List<double> list = new List<double>();
            List<double> list2 = new List<double>();
            // nhap tung phan tu vao list
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}: ", i + 1);
                double a = int.Parse(Console.ReadLine());
                list.Add(a);
                list2.Add(Math.Pow(a, 2));
            }
            foreach (double i in  list2)
            {
                if (i > 50)
                {
                    dem++;
                }
            }
            Console.WriteLine("List 1 la");
            foreach (double i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("List 2 moi duoc tao ra la binh phuong cua list1 la");
            foreach (double i in list2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("So phan tu lon hon 50 trong list 2 la {0}", dem);*/

            // bai 28: tim phan tu lon thu 2 va nho thu 2 cua list
            // list lay ngau nhien
            Random rnd = new Random();
            Console.WriteLine("Nhap vao n phan tu: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int a = rnd.Next(1, 101);
                list.Add(a);
            }
            // hien thi list do
            Console.Write("List0: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // tim gia tri lon nhat va nho nhat -> xoa di -> Sort list
            list.Sort();
            Console.Write("List1 :");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            int gtmax = list.Max();
            int gtmin = list.Min();
            list.Remove(gtmax);
            list.Remove(gtmin);
            
            Console.WriteLine();
            // hien thi gia tri lon thu nhat va thu 2 trong list
            Console.WriteLine("Gia tri lon thu 2 la {0}", list[n-1-2]);
            Console.WriteLine("Gia tri nho thu 2 la {0}", list[0]);
            Console.ReadKey();
        }
    }
}
