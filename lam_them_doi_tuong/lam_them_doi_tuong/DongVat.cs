using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class DongVat
    {
        private string MaDV;
        private string TenLoai;
        private string GiongLoai;
        private string KhuVucSong;
        private string ThucAn;

        public DongVat()
        {
            Console.WriteLine("in động vật");
        }
        public DongVat(string maDV, string tenLoai, string giongLoai, string khuVucSong, string thucAn)
        {
            MaDV1 = maDV;
            TenLoai1 = tenLoai;
            GiongLoai1 = giongLoai;
            KhuVucSong1 = khuVucSong;
            ThucAn1 = thucAn;
        }

        public string MaDV1 { get => MaDV; set => MaDV = value; }
        public string TenLoai1 { get => TenLoai; set => TenLoai = value; }
        public string GiongLoai1 { get => GiongLoai; set => GiongLoai = value; }
        public string KhuVucSong1 { get => KhuVucSong; set => KhuVucSong = value; }
        public string ThucAn1 { get => ThucAn; set => ThucAn = value; }

        public void inDongVat()
        {
            Console.WriteLine($"{MaDV} | {TenLoai} | {GiongLoai} | {KhuVucSong} | {ThucAn}");
        }
    }
}
