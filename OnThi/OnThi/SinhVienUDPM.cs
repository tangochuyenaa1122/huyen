using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    internal class SinhVienUDPM:SinhVienFPOLY
    {
        private int chuyenNganhHep;

        public SinhVienUDPM()
        {

        }
        public SinhVienUDPM(int maSV, string hoTen, int chuyenNganh, int chuyenNganhHep) : base(maSV, hoTen, chuyenNganh)
        {
            this.ChuyenNganhHep = chuyenNganhHep;
        }

        public int ChuyenNganhHep { get => chuyenNganhHep; set => chuyenNganhHep = value; }

        public override void InThongTin()
        {
            Console.WriteLine($"THÔNG TIN SINH VIÊN {MaSV}");
            Console.WriteLine($"Mã SV: {MaSV} ");
            Console.WriteLine($"Họ tên SV: {HoTen}");
            Console.WriteLine($"Chuyên Ngành: {(ChuyenNganh == 1 ? "UDPM" : "WEB")}");
            Console.WriteLine($"Chuyên ngành hẹp: {(ChuyenNganhHep == 1 ? "Java" : ChuyenNganhHep == 2 ? "C#" : "Không có")}");
        }
    }
}
