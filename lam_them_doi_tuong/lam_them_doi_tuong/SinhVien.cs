using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class SinhVien
    {
        private string Ten;
        private string TenDem;
        private string HoTen;
        private string MaSV;
        private string Email;
        private string Sdt;
        private string SdtNguoiThan;
        private string NganhHoc;

        public SinhVien()
        {
            Console.WriteLine("in sinh viên");
        }
        public SinhVien(string ten, string tenDem, string hoTen, string maSV,
            string email, string sdt, string sdtNguoiThan, string nganhHoc)
        {
            Ten1 = ten;
            TenDem1 = tenDem;
            HoTen1 = hoTen;
            MaSV1 = maSV;
            Email1 = email;
            Sdt1 = sdt;
            SdtNguoiThan1 = sdtNguoiThan;
            NganhHoc1 = nganhHoc;
        }

        public string Ten1 { get => Ten; set => Ten = value; }
        public string TenDem1 { get => TenDem; set => TenDem = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Sdt1 { get => Sdt; set => Sdt = value; }
        public string SdtNguoiThan1 { get => SdtNguoiThan; set => SdtNguoiThan = value; }
        public string NganhHoc1 { get => NganhHoc; set => NganhHoc = value; }

        public void inSinhVien()
        {
            Console.WriteLine($"{Ten} | {TenDem} | {HoTen} | {MaSV} | {Email} | {Sdt} |{SdtNguoiThan} | {NganhHoc}");
        }
    }
}
