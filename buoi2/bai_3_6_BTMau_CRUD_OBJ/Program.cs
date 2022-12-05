using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_6_BTMau_CRUD_OBJ
{
    internal class Program
    {
        /*
         * 1.program
         * 2.Nguoi
         * 3.NguoiYeuMoi
         * 4.NguoiYeuMoiService
         */
        static void Main(string[] args)
        {
            NguoiYeuMoiService nym = new NguoiYeuMoiService();
            do
            {
                //nym.themNY();
                nym.InDS();
                //nym.TimKiem();
                //nym.Xoa();
                //nym.Sua();
            }while (true);
        }
    }
}
