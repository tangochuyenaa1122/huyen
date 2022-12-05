using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    internal class SinhVienFPOLY
    {
        private int maSV;
        private string hoTen;
        private int chuyenNganh;

        public SinhVienFPOLY()
        {

        }
        public SinhVienFPOLY(int maSV, string hoTen, int chuyenNganh)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.ChuyenNganh = chuyenNganh;
        }

        public int MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }

        public virtual void InThongTin()
        {

        }
    }
}
