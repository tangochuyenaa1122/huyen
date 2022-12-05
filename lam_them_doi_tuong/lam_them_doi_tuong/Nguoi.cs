using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class Nguoi
    {
        private string Ten;
        private int Tuoi;
        private string Sdt;
        private string DiaChi;
        private string NgaySinh;
        private string QueQuan;
        private string TrinhDo;

        
        public Nguoi(string ten, int tuoi, string sdt, string diaChi, string ngaySinh, string queQuan, string trinhDo)
        {
            Ten1 = ten;
            Tuoi1 = tuoi;
            Sdt1 = sdt;
            DiaChi1 = diaChi;
            NgaySinh1 = ngaySinh;
            QueQuan1 = queQuan;
            TrinhDo1 = trinhDo;
        }

        public string Ten1 { get => Ten; set => Ten = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }
        public string Sdt1 { get => Sdt; set => Sdt = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public string TrinhDo1 { get => TrinhDo; set => TrinhDo = value; }

        public void InNguoi()
        {
            Console.WriteLine($"{Ten} | {Tuoi} | {Sdt} | {DiaChi} | {NgaySinh} | {QueQuan} | {TrinhDo}");
        }
    }
}
