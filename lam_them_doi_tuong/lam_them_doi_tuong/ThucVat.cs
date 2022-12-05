using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class ThucVat
    {
        private string maTV;
        private string tenLoai;
        private string khuVuc;

        public ThucVat()
        {
            Console.WriteLine("in thực vật");
        }
        public ThucVat(string maTV, string tenLoai, string khuVuc)
        {
            this.MaTV = maTV;
            this.TenLoai = tenLoai;
            this.KhuVuc = khuVuc;
        }

        public string MaTV { get => maTV; set => maTV = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }

        public void inThucVat()
        {
            Console.WriteLine($"{maTV} | {tenLoai} | {khuVuc}");
        }
    }
}
