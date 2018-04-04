using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTF
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] intmassive = { 10, 3, 9, 3, 4, 6, 745, 43, 43 };
            for (int i = 0; i < intmassive.Length; i++)
            {
               
                if (intmassive[i]> 10)
                {
                    double b = Math.Sqrt(intmassive[i]);
                    intmassive[i] = b;





                }



            }
            for (int i = 0; i < intmassive.Length; i++)
            {
                Console.Write(intmassive[i]+ ", "); 
            }
            Console.Write("\n");



        }
    }
}
