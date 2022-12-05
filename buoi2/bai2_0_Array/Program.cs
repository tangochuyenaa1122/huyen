using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_0_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. khai báo biến
            int a = 5;

            //2. khai báo mảng
            int[] arrNumbers;
            arrNumbers = new int[a];//khởi tạo mảng có a phần tử

            string[] arrNames = new string[5];//khởi tạo mảng có 5 phần tử
            string[] arrMonHoc = new string [] {"c#1","c#2","c#3"};// khai báo tường minh
            string[] arrMonHoc1 = new [] {"c#1","c#2","c#3"};// khai báo ngầm định
            //3.gán giá trị trong mảng cần index
            arrNumbers[0] = 8;// gán giá trị cho index 0
            arrNumbers[1] = 58;
            arrNumbers[2] = 35;
            arrNumbers[0] = 99;// ghi đè giá trị tại index 0

            //4.lấy giá trị
            //lấy giá trị đơn
            Console.WriteLine(arrNumbers[0]);
            //cả mảng
            foreach (var x in arrNumbers)
            {
                Console.WriteLine(x +" ");
            }
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }
        }
    }
}
