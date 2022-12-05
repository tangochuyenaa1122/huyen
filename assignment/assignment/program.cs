using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GiaoVienService GV = new GiaoVienService();
            int x;
            do
            {
                Console.WriteLine("--------------MENU-------------");
                Console.WriteLine("1. THÊM - SỬA - XÓA GIÁO VIÊN");
                Console.WriteLine("2. THÊM 15 GV TẠO SẴN VÀO TRONG DANH SÁCH");
                Console.WriteLine("3. TÌM KIẾM GIÁO VIÊN THEO MÃ GIÁO VIÊN ");
                Console.WriteLine("4. LOAD TẤT TT CẢ GV  - (Lưu ý: Khi hiển thị những " +
                                    "người có giới tính là NAM thì hiển thị là Thầy và NỮ thì hiển thị là CÔ)");
                Console.WriteLine("5. TÌM KIẾM THEO TÊN GV GẦN ĐÚNG");
                Console.WriteLine("6. LOAD TẤT CẢ GIÁO VIÊN CÓ SỐ GIỜ DẠY LỚN HƠN 500 GIỜ");
                Console.WriteLine("7. LOAD TẤT CẢ GIÁO VIÊN VÀ PH N CHIA DANH SÁCH KHI HIỂN THỊ THEO NHÓM VÙNG MIỀN" +
                                    "( - Hà Nội: danh sách các GV ở HN - Hải phòng: Tất cả giáo viên hải phòng)");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("------------------------------------");
                Console.WriteLine();
                Console.Write("MỜI BẠN CHỌN CHỨC NĂNG (từ 0-7): ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        GV.Them_Sua_Xoa();
                        Console.Clear();
                        break;
                    case 2:
                        GV.ThemGiaoVien();
                        break;
                    case 3:
                        GV.TimThemMaGV();
                        break;
                    case 4:
                        GV.LoadTheoGT();;
                        break;
                    case 5:
                        GV.TimTheoTen();
                        break;
                    case 6:
                        GV.LoadTheoSoGioDay();
                        break;
                    case 7:
                        GV.LoadTheoVung();
                        break;
                    case 0:
                        Console.WriteLine("Hẹn gặp lại.");
                        break;
                    default:
                        Console.WriteLine("CHỨC NĂNG KHÔNG TỒN TẠI!");
                        Console.WriteLine("MỜI CHỌN LẠI.");
                        break;
                }
            } while (x !=0);
        }
        
            
        
    }
}
