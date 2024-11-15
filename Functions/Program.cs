using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yazdir(1, "merhabaAA", 3.14, true);
            Console.WriteLine(Topla(2, 6, 8, 7, 5));

        }

        static void Yazdir(params object[] nesneler)
        {
            foreach (object nesne in nesneler)
            {
                Console.WriteLine(nesne);
            }
        }

        static int Topla(params int[] numbers)
        { return numbers.Sum(); }
    }
}
