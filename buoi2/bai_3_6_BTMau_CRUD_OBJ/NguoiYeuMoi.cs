using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_6_BTMau_CRUD_OBJ
{
    internal class NguoiYeuMoi:Nguoi
    {
        private double canNang;
        private string soThich;

        public NguoiYeuMoi()
        {
           
        }
        public NguoiYeuMoi(string ten, string sdt, int gioiTinh, double canNang, string soThich) : base(ten, sdt, gioiTinh)
        {
            this.CanNang = canNang;
            this.SoThich = soThich;
        }

        public double CanNang { get => canNang; set => canNang = value; }
        public string SoThich { get => soThich; set => soThich = value; }
        public string DanhGia { get => canNang<=50?"Gầy":canNang<=80?"Đẹp":"Đáng Yêu"; }


        public override void InRaManHinh()
        {
            Console.WriteLine($"{Ten} | {Sdt} | {(GioiTinh == 1 ? "Nam" : "Nữ")} | {canNang} | {soThich} | {DanhGia}");
        }
    }
}
