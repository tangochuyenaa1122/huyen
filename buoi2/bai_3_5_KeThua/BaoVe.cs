using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_5_KeThua
{
    internal class BaoVe:Nguoi
    {
        private string mnv;
        private string catruc;

        public BaoVe(string ten, string ns, string sdt, string cccd, string ngaySinh, string email, string diaChi, string mnv, string catruc) : base(ten, ns, sdt, cccd, ngaySinh, email, diaChi)
        {
            this.mnv = mnv;
            this.catruc = catruc;
        }
    }
}
