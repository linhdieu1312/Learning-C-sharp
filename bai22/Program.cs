using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    // khai bao 1 lop

    internal class Program
    {
        static void Main(string[] args)
        {
            // oop  
            // khai bao doi tuong moi: TenClass tenObj = new TenClass()
            SinhVien sv1 = new SinhVien();
            // khai bao doi tuong moi: TenClass tenObj = new TenClass()
            SinhVien sv2 = new SinhVien();
            Console.WriteLine("SV2: " + sv2.MaSV);
            Console.WriteLine("SV2 name: " + sv2.NameSV);

            SinhVien sv3 = new SinhVien(10, "Le Dieu Linh", 10);
            Console.WriteLine("SV3: " + sv3.MaSV);
            Console.WriteLine("SV3 name: " + sv3.NameSV);

            // goi phuong thuc / method ToString
            Console.WriteLine(sv1.ToString());
            Console.WriteLine(sv3.ToString());
            Console.WriteLine("--------------");
            // method ToString: mac dinh hien thi neu chi goi ra doi tuong: CACH VIET GON
            Console.WriteLine(sv3);
            Console.WriteLine("--------------");
            sv3.Display();

            Console.WriteLine("Tinh tong: ");
            Console.WriteLine("[double]: " + sv3.Total(1.5, 6.5));
            Console.WriteLine("[int]: " + sv3.Total(1, 3, 6));

            Console.WriteLine("Diem TB: " + sv3.DiemTB(10, 8, 9, 10, 9.5, 8.5, 9.2));

            // Test thu voi Auto implemented properties
            HocSinh hs = new HocSinh();
            hs.name = "Linh";
            hs.phone = "012345";
            hs.email = "linh@gmail.com";
            Console.WriteLine(hs.ToString());
            Console.ReadKey();
        }
    }
}
