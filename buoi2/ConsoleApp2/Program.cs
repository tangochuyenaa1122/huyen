using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] fr1 = new int[100];
            int n, i, j, bien_dem;

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                fr1[i] = -1;
            }
            for ( i = 0; i < arr1.Length - 1; i++)
            {
                for ( j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        int temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            for (i = 0; i < n; i++)
            {
                bien_dem = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        bien_dem++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = bien_dem;
                }
            }
            
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write($"{arr1[i]} - {fr1[i]};");
                }
            }

        }
    }
}
