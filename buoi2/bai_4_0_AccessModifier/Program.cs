using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4_0_AccessModifier
{
    internal class Program
    {
        /*
         * AccessModifier: sử dụng trên biến, phương thức
         * public
         * private: chỉ sử dụng trong class
         * protected: chỉ cho phép lớp con có quyền truy cập và trong cùng 1 class vấn truy cập đc
         * internal:chỉ sử dụng trong 1 thư mục
         * 
         * Ngoài ra còn 2 sự kết hợp: protected internal,private protected
         */
        class SinhVien 
        {
            private string att;//private 
            public string Att2;
            string att3;//private
            internal string att4;
            protected string att5;
        }

        class SVUD : SinhVien
        {
            public SVUD()
            {
                att5 = " ";
            }
        }
        static void Main(string[] args)
        {
            SinhVien sv= new SinhVien();
            sv.Att2 = "df";
            sv.att4 = "fr";
            //sv.att3 = "ff";
        }
    }
}
