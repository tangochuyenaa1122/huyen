using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1_7_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string input;
            do
            {
                Console.WriteLine("menu ăn sáng");
                Console.WriteLine("1.Phở bò");
                Console.WriteLine("2.Bún bò");
                Console.WriteLine("3.Cơm bò");
                Console.Write("Mời bạn chọn món: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("1.Phở bò");
                        break;
                    case "2":
                        Console.WriteLine("2.Bún bò");
                        break;
                    case "3":
                        Console.WriteLine("3.Cơm bò");
                        break;
                    case "4":
                        Console.WriteLine("Hẹn gặp lại");
                        //cách 2:thoát 
                        Environment.Exit(4);
                        break;
                    default:
                        Console.WriteLine("Món ăn không tồn tại");
                        break;
                }
            } while (input != "");

        }
    }
}
