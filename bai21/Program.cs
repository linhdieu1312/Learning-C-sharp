using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai21
{
    internal class Program
    {
        // Ngoai le
        static void NgoaiLe()
        {
            try
            {
                Console.WriteLine("Moi nhap vao DOB: ");
                string s = Console.ReadLine();
                DateTime bd = DateTime.Parse(s);
                Console.WriteLine("Your DOB is " + bd.ToString("dd/MM/yyyy"));
            }
            catch (Exception e) // bat ngoai le, bao loi len man hinh chinh
            {
                Console.WriteLine(e.Message);
            }
            finally { Console.WriteLine("Thank you for using"); }
            
        }

        // nem ngoai le ra cho khac: ngoai le so hoc
        static void NgoaiLe2()
        {
            Console.WriteLine("Nhap vao tu so: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao mau so: ");
            int b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                // nem ra 1 ngoai le so hoc la mau != 0
                throw new ArithmeticException("Mau so khong duoc bang 0");
            }
        }

        static void Main(string[] args)
        {
            //NgoaiLe();

            // goi ham NgoaiLe2
            try
            {
                NgoaiLe2();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
