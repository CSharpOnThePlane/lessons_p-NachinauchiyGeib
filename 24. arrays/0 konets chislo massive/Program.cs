using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_konets_chislo_massive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intmassive = { 10, 3, 0, 30, 4, 6, 300, 6660, 43 };
            for (int i = 0; i < intmassive.Length; i++)
            {
                int b = intmassive[i] % 10;
                if (b == 0)
                {
                    Console.Write(intmassive[i] + ",");
                }



            }
            Console.Write("\n");






        }
    }
}
