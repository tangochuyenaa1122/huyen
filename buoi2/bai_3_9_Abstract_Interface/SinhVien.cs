using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_9_Abstract_Interface
{
    /*
     * khi lớp con kế thừa 1 lớp abstract thì bắt buộc phải ghi đè hết tất cả các phương thức abstract của lớp con
     */
    internal class SinhVien:Nguoi
    {
        private string att4;

        public SinhVien()
        {

        }
        public SinhVien(string att1, string att2, string att3, string att4) : base(att1, att2, att3)
        {
            this.Att4 = att4;
        }

        public string Att4 { get => att4; set => att4 = value; }

        public override void method1(int a, string b)
        {
            base.method1(a, b);
        }
        public override void method2(int a, string b)
        {
            base.method2(a, b);
        }

        public override int method3()
        {
            //triển khai code bth
            return 1 + 1;
        }

        public override void method3(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
