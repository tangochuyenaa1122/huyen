using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bai_3_7_xử_lý_chuỗi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //viDu1();
            viDu2();
            //VD3();
           
        }
        //VÍ DỤ 1:
        public static void viDu1()
        {
            List<string> lstNames = new List<string>() { "ABC", "abc", "dac", "uob" ,"a12"};
            //in ra các chuỗi bắt đầu bằng a
            foreach (var x in lstNames)
            {
                if (x.StartsWith("a"))
                {
                    Console.WriteLine(x + " ");
                }
            }
            Console.WriteLine();

            foreach (var x in lstNames)
            {
                if (x.Contains("a"))//kiểm tra kí tự trong chuỗi
                {
                    Console.WriteLine(x + " ");
                }
            }
            Console.WriteLine();

            foreach (var x in lstNames)
            {
                if (x.ToLower().Contains("a".ToLower()))//ToLower viết thường chuỗi
                {
                    Console.WriteLine(x + " ");
                }
            }
            Console.WriteLine();
        }
        //VÍ DỤ 2: biến đổi tên thành mã
        public static void viDu2()
        {
            do
            {
                string input, namesVietHoa="";
                Console.WriteLine("Mời bạn nhâp tên: ");
                input = Console.ReadLine();
                //đưa chuỗi về mảng
                string[] arrNames = input.Split(' ');
                foreach (var x in arrNames)
                {
                    namesVietHoa += vietHoaChuCaiDau(x) + " ";
                }

                //THỰC HIỆN HÀNH ĐỘNG TẠO MÃ
                Console.WriteLine($"Tên sau khi viết hoa chữ cái đầu: \n {namesVietHoa}");
                Console.WriteLine($"mã sv: {zemMaFpoly(input, 4552)}");
            } while (true);
            
        }
        //phương thức zen mã sv fpoly
        public static string zemMaFpoly(string fullName, int number)
        {
            string[] arrNames = fullName.Split(' ');
            string masv = vietHoaChuCaiDau(arrNames[arrNames.Length - 1]) ;
            for (int i = 0; i < arrNames.Length-1; i++)
            {
                //lấy chữ cái đầu(vị trí 0) trong phần tử i
                masv +=char.ToUpper( arrNames[i][0]);
            }
            return masv + "ph" +number;
        }
        public static string vietHoaChuCaiDau(string text)
        {
            var temp = text.ToLower();
            return temp.Substring(0,1).ToUpper() + temp.Substring(1,temp.Length-1);
        }
        //VÍ DỤ 3:kiểm tra kiểu đầu vào và bắt nhập đúng
        public static void VD3()
        {
            string input;
            do
            {
                Console.WriteLine("Mời bạn nhập số: ");
                input = Console.ReadLine();

            } while (!checkSo_Chu(input,1));
            Console.WriteLine("đã nhập đúng");
        }
        //PHƯƠNG THỨC CHECK SỐ , CHỮ ...
        public static bool checkSo_Chu(string text, int a)
        {
            if (a==1)//check số
            {
                return Regex.IsMatch(text, @"^\d+$");
            }
            return Regex.IsMatch(text, @"^[a-zA-Z]+$");
        }
    }
}
