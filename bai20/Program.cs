using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai20
{
    internal class Program
    {
        // khai bao ham 
        static int Total(int x, int y, int z)
        {
            return x + y + z;
        }
        /// <summary>
        /// Tinh giai thua cua n: Cthuc: n!=1*2..*n
        /// </summary>
        /// <param name="n">Nhap so nguyen n</param>
        /// <returns>tich cac so tu 1 den n: 1*2*3*..*n</returns>
        static int GiaiThua(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else
            {
                int kq = GiaiThua(n - 1) * n;
                return kq;
            }
        }
        // Vi du ham thu tuc voi void
        static void Display(string name)
        {
            Console.WriteLine("Hello, nice to see u {0}", name);
        }

        // Tham chieu ref
        static void ThamChieu(ref int c)
        {
            c++;
            Console.WriteLine("c trong ham tham chieu ref la {0}", c);
        }
        // tham chieu out
        static void ThamChieuOut(out int b)
        {
            b = 10;
            Console.WriteLine("b trong ham tham chieu out la {0}", ++b); 
            // gia tri tien to hay hau to o day rat quan tron, 
            // neu la b++ thi hien thi 10, sau do neu co su dung bien out b thi b khi do la 11
            // neu la ++b thi ket qua tu dau la 11, sau do bien van dc su dung la gia tri 11
        }
        // ham Main
        static void Main(string[] args)
        {
            // goi ham return trong Main
            int total = Total(1, 2, 3);
            Console.WriteLine("Tong la" + total);
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Giai thua cua {0} la {1}", n, GiaiThua(n));

            // goi ham thu tuc
            Console.WriteLine("May I know ur name? ");
            string name = Console.ReadLine();
            Display(name);

            //goi ham tham chieu ref
            int b = 4;
            Console.WriteLine("Gia tri cua b truoc khi goi ham tham chieu ref la {0}", b);
            ThamChieu(ref b);
            Console.WriteLine("Gia tri cua b sau khi goi ham tham chieu ref la {0}", b);
            //
            ThamChieuOut(out int c); //11
            Console.WriteLine("Gia tri bien khi goi ham tham chieu out la {0}", c); //11
            Console.WriteLine("Gia tri bien khi ket thuc ham tham chieu out la {0}", ++c);//11
            // neu o day la ++c, tien do thi n se duoc tinh va hien thi gia tri c=12
            Console.ReadKey();
        }
    }
}
