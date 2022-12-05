using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_4_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region 1.phương thức ko trả về
            //cách gọi phương thức: cần bt tên và phương thức đang nằm trong class nào
            Methodvoid mt = new Methodvoid();//phương thức nằm ở đây
            //mt.TinhTong2So();//gọi đến phương thức cần sử dụng và kết thúc = ();

            mt.TinhTong(4,  4 , 2);//truyền số lượng tham số sẽ quyết định gọi vào những phương thức nào

            #endregion
            #region 2.phương thức trả về
            //cách thức gọi rồi chuyền tham số tương tự void
            Method_TraVe mt1 = new Method_TraVe();
            Console.WriteLine(mt1.TinhTong(5,6));

            int[] arrTemp = mt1.getYears1800_2022();
            for (int i = 0; i < mt1.getYears1800_2022().Length; i++)
            {
                Console.WriteLine(mt1.getYears1800_2022()[i]);
            }

            //VD: viết 1 phương trình tập tên người có sẵn rồi in ra trên program
            
            Method_TraVe mt2 = new Method_TraVe();
            foreach (var x in mt2.Nguoi())
            {
                Console.WriteLine(x);
            }
            #endregion
        }
    }
}
