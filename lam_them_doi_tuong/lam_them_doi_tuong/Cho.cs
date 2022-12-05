using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class Cho
    {
        private string MaCho;
        private string TenCho;
        private string GioiTinh;
        private string ThucAnYeuThich;
        private string NgaySinh;

        public Cho()
        {
            Console.WriteLine("in chó");
        }
        public Cho(string maCho, string tenCho, string gioiTinh, string thucAnYeuThich, string ngaySinh)
        {
            MaCho1 = maCho;
            TenCho1 = tenCho;
            GioiTinh1 = gioiTinh;
            ThucAnYeuThich1 = thucAnYeuThich;
            NgaySinh1 = ngaySinh;
        }

        public string MaCho1 { get => MaCho; set => MaCho = value; }
        public string TenCho1 { get => TenCho; set => TenCho = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string ThucAnYeuThich1 { get => ThucAnYeuThich; set => ThucAnYeuThich = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }

        public void inCho()
        {
            Console.WriteLine($"{MaCho} | {TenCho} | {GioiTinh} | {ThucAnYeuThich} | {NgaySinh}");
        }
    }
}
