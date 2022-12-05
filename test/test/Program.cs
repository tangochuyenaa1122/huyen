using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bai3();


        }

        static void bai0()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int batDau, KetThuc;
            int i,j;
            Console.WriteLine("Mời bạn nhập vào khoảng 1: ");
            batDau = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập vào khoảng 2: ");
            KetThuc = Convert.ToInt32(Console.ReadLine());
            if (batDau<KetThuc)
            {
                for (i = batDau; i <= KetThuc; i++)
                {
                    for (j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{i} x {j} = {i*j}");
                    }
                }
            }
            else
            {
                for (i = KetThuc; i <= batDau; i++)
                {
                    for (j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                    }
                }
            }
        }
        static void bai1()
        {
            Console.OutputEncoding=Encoding.UTF8;
            int[] arrNumbers;
            int size;
            Console.WriteLine("Mời nhập kích thước mảng: ");
            size = Convert.ToInt32(Console.ReadLine());
            arrNumbers = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"mời nhập phần tử thứ {i+1}: ");
                arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("số chẵn:");
            foreach (var x in arrNumbers)
            {
                Console.Write((x%2==0? Convert.ToString(x):"") +" ");
            }
            Console.WriteLine();
            Console.Write("số lẻ:");
            foreach (var x in arrNumbers)
            {
                Console.Write((x % 2 != 0 ? Convert.ToString(x) : "")+ " ");
            }
            Console.WriteLine();
        }
        static void bai3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] arrSV;
            int size;
            string ten, maSV;
            int namSinh;
            Console.WriteLine("Mời nhập số lượng sv: ");
            size= Convert.ToInt32(Console.ReadLine());
            arrSV = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("mời nhập tên:");
                ten = Console.ReadLine();
                Console.Write("mời nhập mã sv:");
                maSV = Console.ReadLine();
                Console.Write("mời nhập năm sinh:");
                namSinh = Convert.ToInt32(Console.ReadLine());
                arrSV[i] = ten + "            " + maSV + "     " + namSinh +"     " + (2022 - namSinh);
            }
            Console.WriteLine("Tên            MaSV     Năm Sinh     Tuổi");
            foreach (var x in arrSV)
            {
                Console.WriteLine(x);
            }
        }
    }
}
