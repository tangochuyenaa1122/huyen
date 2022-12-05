using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class Oto
    {
        private string maOto;
        private string hangOto;
        private string dongCo;
        private string nhienLieu;
        private int giaTien;

        public Oto()
        {
            Console.WriteLine("in ô tô");
        }
        public Oto(string maOto, string hangOto, string dongCo, string nhienLieu, int giaTien)
        {
            this.MaOto = maOto;
            this.HangOto = hangOto;
            this.DongCo = dongCo;
            this.NhienLieu = nhienLieu;
            this.GiaTien = giaTien;
        }

        public string MaOto { get => maOto; set => maOto = value; }
        public string HangOto { get => hangOto; set => hangOto = value; }
        public string DongCo { get => dongCo; set => dongCo = value; }
        public string NhienLieu { get => nhienLieu; set => nhienLieu = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }

        public void inOto()
        {
            Console.WriteLine($"{maOto} | {hangOto} | {dongCo} | {nhienLieu} | {giaTien}");
        }
    }
}
