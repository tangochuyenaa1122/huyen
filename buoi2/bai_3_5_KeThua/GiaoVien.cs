using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_5_KeThua
{
    internal class GiaoVien:Nguoi
    {
        private string mgv;
        private string nganhDay;
        public GiaoVien()
        {

        }
        public GiaoVien(string ten, string ns, string sdt, string cccd, string ngaySinh, string email, string diaChi, string mgv, string nganhDay) : base(ten, ns, sdt, cccd, ngaySinh, email, diaChi)
        {
            this.Mgv = mgv;
            this.NganhDay = nganhDay;
        }

        public string Mgv { get => mgv; set => mgv = value; }
        public string NganhDay { get => nganhDay; set => nganhDay = value; }
    }
    
    
}
