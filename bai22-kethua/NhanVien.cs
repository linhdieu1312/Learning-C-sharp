using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_kethua
{
    public class NhanVien
    {
        // khoi tao thuoc tinh
        public string MaNV { get; set; }
        public string TenNV { get; set; }

        // khoi tao cac method
        public double TinhLuong()
        {
            return 1000;
        }

        // override: ghi de
        // khai bao them virtual o lop cha de the hien phuong thuc nay co the nap chong duoc
        // o lop con them override o phuong thuc de nhan ghi de phuong thuc nay
        public virtual double ThuongCong (int NgayCong)
        {
            if (NgayCong > 26) return 100;
            else return 0;
        }
    }
}
