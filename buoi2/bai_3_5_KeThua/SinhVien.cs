using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_5_KeThua
{
    /*
     * 1. để sử dụng kế thừa dùng dấu :
     * 2. trong c# và JAVA chỉ cho phép đơn kế thừa
     */
    internal class SinhVien:Nguoi
    {
        //lớp con chỉ cần kahi báo các thuộc tính đặc trưng riêng
        private string msv;
        private string nganhHoc;

        public SinhVien()
        {

        }
        public SinhVien(string ten, string ns, string sdt, string cccd, string ngaySinh, string email, string diaChi, string msv, string nganhHoc) : base(ten, ns, sdt, cccd, ngaySinh, email, diaChi)
        {
            this.Msv = msv;
            this.NganhHoc = nganhHoc;
        }

        public string Msv { get => msv; set => msv = value; }
        public string NganhHoc { get => nganhHoc; set => nganhHoc = value; }

        public override int Method1(int a, int b)
        {
            // khi đã kế thừa phương thức lớp con có thể toàn quyền code lại nội dung bên trong phương thức
            return base.Method1(a, b);
        }

        public override void Method2()
        {
            Console.WriteLine("đây là phương thức lớp con đã edit");
        }
    }
}
