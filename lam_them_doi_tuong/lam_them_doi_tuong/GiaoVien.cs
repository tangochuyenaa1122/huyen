using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class GiaoVien
    {
        private string Ten;
        private string TenDem;
        private string HoTen;
        private string MaGV;
        private string Email1;
        private string Email2;
        private string Sdt;
        private int    SoGioDay;
        private string ChucVu;

        public GiaoVien()
        {
            Console.WriteLine("in giáo viên");
        }
        public GiaoVien(string ten, string tenDem, string hoTen, string maGV,
            string email1, string email2, string sdt, int soGioDay, string chucVu)
        {
            Ten1 = ten;
            TenDem1 = tenDem;
            HoTen1 = hoTen;
            MaGV1 = maGV;
            Email11 = email1;
            Email21 = email2;
            Sdt1 = sdt;
            SoGioDay1 = soGioDay;
            ChucVu1 = chucVu;
        }

        public string Ten1 { get => Ten; set => Ten = value; }
        public string TenDem1 { get => TenDem; set => TenDem = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string MaGV1 { get => MaGV; set => MaGV = value; }
        public string Email11 { get => Email1; set => Email1 = value; }
        public string Email21 { get => Email2; set => Email2 = value; }
        public string Sdt1 { get => Sdt; set => Sdt = value; }
        public int SoGioDay1 { get => SoGioDay; set => SoGioDay = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }

        public void InGiaoVien()
        {
            Console.WriteLine($"{Ten} | {TenDem} | {HoTen} | {MaGV} | {Email1} | {Email2} | {Sdt} | {SoGioDay} | {ChucVu}");
        }
    }
}
