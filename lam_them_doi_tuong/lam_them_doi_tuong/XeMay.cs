using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class XeMay
    {
        private string MaXeMay;
        private string TenXeMay;
        private string HangXeMay;
        private string LoaiXeMay;
        private string NhienLieu;
        private string DongCo;
        private int GiaTien;

        public XeMay()
        {
            Console.WriteLine("in xe máy");
        }
        public XeMay(string maXeMay, string tenXeMay, string hangXeMay, 
            string loaiXeMay, string nhienLieu, string dongCo, int giaTien)
        {
            MaXeMay1 = maXeMay;
            TenXeMay1 = tenXeMay;
            HangXeMay1 = hangXeMay;
            LoaiXeMay1 = loaiXeMay;
            NhienLieu1 = nhienLieu;
            DongCo1 = dongCo;
            GiaTien1 = giaTien;
        }

        public string MaXeMay1 { get => MaXeMay; set => MaXeMay = value; }
        public string TenXeMay1 { get => TenXeMay; set => TenXeMay = value; }
        public string HangXeMay1 { get => HangXeMay; set => HangXeMay = value; }
        public string LoaiXeMay1 { get => LoaiXeMay; set => LoaiXeMay = value; }
        public string NhienLieu1 { get => NhienLieu; set => NhienLieu = value; }
        public string DongCo1 { get => DongCo; set => DongCo = value; }
        public int GiaTien1 { get => GiaTien; set => GiaTien = value; }

        public void inXeMay()
        {
            Console.WriteLine($"{MaXeMay} | {TenXeMay} | {HangXeMay} | {LoaiXeMay} | {NhienLieu} | {DongCo} | {GiaTien}");
        }
    }
}
