using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class GiaoVien:Person
    {
        
        private string MaGv;
        private string Sdt1;
        private string Email;      
        private int SoGioDay;

        public GiaoVien()
        {
           
        }

        public GiaoVien(string ho, string ten, string tenDem, int namSinh, int gioITinh, string queQuan, string maGv, string sdt1, string email, int soGioDay) : base(ho, ten, tenDem, namSinh, gioITinh, queQuan)
        {
            MaGv1 = maGv;
            Sdt11 = sdt1;
            Email1 = email;
            SoGioDay1 = soGioDay;
        }

        public string MaGv1 { get => MaGv; set => MaGv = value; }
        public string Sdt11 { get => Sdt1; set => Sdt1 = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int SoGioDay1 { get => SoGioDay; set => SoGioDay = value; }

        public override void InRaManHinh()
        {
            Console.WriteLine($" {Ho} | {Ten} | {TenDem} | {NamSinh} | {(GioITinh == 1 ? "Nam" : "nữ")} | {QueQuan}" +
                $"| {MaGv1} | {Sdt11} | {Email1} | {SoGioDay1}");
        }
    }
}
