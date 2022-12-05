using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích.
            //Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.
            int a;
            int i;
            Console.WriteLine("Mời nhập vào dãy có bao nhiêu số: ");
            a = Convert.ToInt32(Console.ReadLine());
            int[] arrNumbers;
            arrNumbers = new int[a];
            Console.WriteLine("mời nhập dãy số:");
            for (i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("các số chẵn:");
            for (i = 0; i < arrNumbers.Length; i++)
            {
                if (arrNumbers[i] % 2 == 0)
                {
                    Console.Write(arrNumbers[i] + " ");
                }
            }
            Console.ReadLine();
            Console.WriteLine("các số lẻ:");
            for (i = 0; i < arrNumbers.Length; i++)
            {
                if (arrNumbers[i] % 2 == 1)
                {
                    Console.Write(arrNumbers[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
