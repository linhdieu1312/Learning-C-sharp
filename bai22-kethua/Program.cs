using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_kethua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = "1010";
            nv.TenNV = "LDL";
            Console.WriteLine("Ten nv la {0} \t Ma NV la {1}", nv.TenNV, nv.MaNV);

            // nv hanh chinh ke thua tu nhan vien
            NVHanhChinh hc = new NVHanhChinh();
            hc.MaNV = "hc1000";
            hc.TenNV = "hcc hcc";
            Console.WriteLine("Ten nvhc la {0} \t Ma NV la {1} \t Luong NVHC la {2}", hc.TenNV, hc.MaNV, hc.TinhLuong());

            // nv theo ca thoi vu: ke thua va cung co bo sung cac thuoc tinh cua rieng
            NVTheoCa tc = new NVTheoCa();
            tc.TenNV = "ca11 ca";
            tc.MaNV = "tc1000";
            tc.Ca = "Sang";
            Console.WriteLine("Ten nvtc la {0} \t Ma NV la {1} \t lam ca {2}", tc.TenNV, tc.MaNV, tc.Ca);
            Console.WriteLine("Tien luong cua nv theo ca la {0}", tc.TinhLuong());

            Console.WriteLine("Thuong cong cho nhan vien {0}", nv.ThuongCong(29));
            Console.WriteLine("Thuong cong cho nv hanh chinh {0}", hc.ThuongCong(28));
            Console.WriteLine("Thuong cong cho nhan vien ca {0}", tc.ThuongCong(29));


            Console.ReadKey();
        }
    }
}
