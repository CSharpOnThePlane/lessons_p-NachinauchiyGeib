using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nadoelo_pridumiyvate_Nazvaniya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tsifri = { 2, 0, 5, 3, 4 };
            int dlinya_tsifri = tsifri.Length;
            for (int i = 0; i < dlinya_tsifri; i++)
            {
                int tsifra = tsifri[i];
                if (tsifra == 5)
                {
                    Console.WriteLine("Molodets comrad, tsifri are horoshie. "+ i+ " vot nomer tsifri pyat");
                    break;
                }
            }



        }
    }
}
