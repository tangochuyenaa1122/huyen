using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_8_thuat_toan_noi_bot_bubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumber = { 7, 3, 6, 2 };
            /*
             * để học giải thuật có 2 cách
             * 1.dùng giấy bút,word,....ghi các bước thức hiện
             * 2.dùng câu lệnh in để in các bước thuật toán
             */
            for (int i = 0; i < arrNumber.Length - 1; i++)
            {
                for (int j = i + 1; j < arrNumber.Length; j++)
                {
                    if (arrNumber[i] > arrNumber[j])
                    {
                        int temp = arrNumber[i];
                        arrNumber[i] = arrNumber[j];
                        arrNumber[j] = temp;
                    }
                }
            }

        }
    }
}
