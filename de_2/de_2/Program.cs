using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XeMayService XM1 = new XeMayService();
            do
            {
                XM1.ThemXe();
                XM1.Sua();
                XM1.Xoa();
                XM1.TimKiem();
                XM1.Xuat();
            } while (true);
        }
    }
}
