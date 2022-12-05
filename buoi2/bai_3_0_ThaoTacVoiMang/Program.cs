using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_0_ThaoTacVoiMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] arrNames = { "B", "T", "D", "A" };
            //IN MẢNG
            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }
            Console.ReadLine();
            //1.sort sử dụng câu lệnh có sẵn
            Console.WriteLine("Săp xếp mảng: ");
            Array.Sort(arrNames);
            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            //2.reverse
            Console.WriteLine("Săp xếp mảng: ");
            Array.Reverse(arrNames);
            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
