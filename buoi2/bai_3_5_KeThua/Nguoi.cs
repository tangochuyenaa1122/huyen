using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_5_KeThua
{
    internal class Nguoi
    {
        private string ten;
        private string ns;
        private string sdt;
        private string cccd;
        private string ngaySinh;
        private string email;
        private string diaChi;
        public Nguoi()
        {

        }
        public Nguoi(string ten, string ns, string sdt, string cccd, string ngaySinh, 
            string email, string diaChi)
        {
            this.Ten = ten;
            this.Ns = ns;
            this.Sdt = sdt;
            this.Cccd = cccd;
            this.NgaySinh = ngaySinh;
            this.Email = email;
            this.DiaChi = diaChi;
        }
        //this: dùng để tham chiếu thuộc tính và phương thức của lớp hiện tại
        //base: dùng để tham chiếu thuộc tính và phương thức của lớp cha

        public string Ten { get => ten; set => ten = value; }
        public string Ns { get => ns; set => ns = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        //để cấp quyền kế thức phương thức cho lớp con thì bổ sung từ khóa virtual
        public virtual int Method1(int a, int b)
        {
            return 0;
        }

        public virtual void Method2()
        {

        }
    }
}
