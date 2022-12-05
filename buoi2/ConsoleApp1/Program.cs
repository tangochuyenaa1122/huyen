
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n ;            
            int[] arr = new int[100];
            int[] brr = new int[100];
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                    arr[i] = Convert.ToInt32(Console.ReadLine()); 
                    brr[i] = -1;
            }
            
            int dem;
            for (int i = 0; i < n; i++)
            {
                dem = 1;
                for (int j = 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        dem++;
                        brr[j] = 0;
                    }
                }
                if (brr[i] != 0)
                {
                    brr[i] = dem;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (brr[i] != 0)
                {
                    Console.Write($"{0}-{1}\n", arr[i], brr[i]);
                }
            }

        }
    }
}

