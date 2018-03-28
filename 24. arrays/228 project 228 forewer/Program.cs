using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _228_project_228_forewer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ops = { 73, 632, 73, 758, 793 };

            int y = 0;
            for (int i = 0; i < ops.Length; i++)
            {
               y = y +  ops[i];
                
            }

            int nah = y%2;
            if (nah== 0)
            {
                Console.WriteLine("summa pologitelnaya");
            }
            else
            {
                Console.WriteLine("summa isn't pologitelnaya");
            }
        }
    }
}
