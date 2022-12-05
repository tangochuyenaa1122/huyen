using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1_9_FOREACH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] arrNumbers = { "f", "a", "g" };
            //FOR
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }
            //FOREACH
            foreach (var x in arrNumbers)
            {
                Console.WriteLine(x);
            }
        }
    }
}
