using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAAA_chetnii_tsifri_in_masive
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] intmassive = {10, 3,9,3,4,6,745,43,43 }     ;
            for (int i = 0; i < intmassive.Length; i++)
            {
                int b =intmassive[i] % 2;
                if (b==0)
                {
                    Console.Write(intmassive[i]+ ",");
                }



            }
            Console.Write("\n");

        }
    }
}
