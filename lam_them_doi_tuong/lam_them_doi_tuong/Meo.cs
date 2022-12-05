using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class Meo
    {
        private string Ten;
        private int Tuoi;
        private string DiaChi;
        private int GioiTinh;
        private string NgaySinh;

        public Meo()
        {
            Console.WriteLine("in mèo");
        }
        public Meo(string ten, int tuoi, string diaChi, int gioiTinh, string ngaySinh)
        {
            Ten1 = ten;
            Tuoi1 = tuoi;
            DiaChi1 = diaChi;
            GioiTinh1 = gioiTinh;
            NgaySinh1 = ngaySinh;
        }

        public string Ten1 { get => Ten; set => Ten = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public int GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }

        public void inMeo()
        {
            Console.WriteLine($"{Ten} | {Tuoi} | {DiaChi} | {(GioiTinh==1?"Nam":"Nữ")} | {NgaySinh}");
        }
    }
}
