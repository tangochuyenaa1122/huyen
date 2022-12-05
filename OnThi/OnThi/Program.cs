using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QLSV qLSV = new QLSV();
            int x;
            do
            {
            Console.WriteLine("1.Nhập 1 danh sách đối tượng(1đ) "); 
            Console.WriteLine("2.Xuất danh sách đối tượng(1đ) "); 
            Console.WriteLine("3.Tìm SV theo khoảng mã sinh viên(1đ) "); 
            Console.WriteLine("4.Xóa sinh viên theo mã nhập và thông báo không tìm thấy(1đ) "); 
            Console.WriteLine("0.Thoát");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        qLSV.ThemSV();
                        break;
                    case 2:
                        qLSV.SuatDS();

                        break;
                    case 3:
                        qLSV.TimSV();
                        break;
                    case 4:
                        qLSV.XoaSV();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Mời bạn chọn lại");
                        break;
                }

            } while (x !=0);
        }
    }
}
