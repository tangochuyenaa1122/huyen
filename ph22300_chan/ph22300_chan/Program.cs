using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ph22300_chan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            XeService xe = new XeService();
            do
            {
                Console.WriteLine("----------MENU----------");
                Console.WriteLine("1.Thêm xe");
                Console.WriteLine("2.Sửa TT");
                Console.WriteLine("3.Xóa");
                Console.WriteLine("4.Tìm Kiếm");
                Console.WriteLine("5.Xuất ra màn hình");
                Console.WriteLine("0.Thoát");
                Console.WriteLine("Mời bạn chọn: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        xe.ThemXe();
                        break;
                    case 2:
                        xe.Sua();
                        break;
                    case 3:
                        xe.Xoa();
                        break;
                    case 4:
                        xe.Tim();
                        break;
                    case 5:
                        for (int i = 0; i < 1; i++)
                        {
                            xe.InDS();
                        }
                        break;
                    default:
                        Console.WriteLine("Mời nhập lại!");
                        break;
                }
            } while (x!=0);
        }
    }
}
