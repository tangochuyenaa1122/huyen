using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_4_Method
{
    internal class Method_TraVe
    {
        public int TinhTong(int a, int b)
        {
            return a + b;
        }

        public int[] getYears1800_2022()
        {
            int[] arr = new int[2023 - 1800];
            int temp = 1800;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = temp;
                temp++;
            }
            return arr;
        }

        //
        public List<string> Nguoi()
        {
            
            return new List<string> { "huyền","linh"};
        }
    }
}
