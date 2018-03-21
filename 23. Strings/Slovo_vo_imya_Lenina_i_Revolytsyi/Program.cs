using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slovo_vo_imya_Lenina_i_Revolytsyi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write slovo vo imya revoliytsyia to we will rastrelyats yiu");
            string slovo = Console.ReadLine();
            int dlinya_slovya = slovo.Length;
            char bukva_odin = slovo[0];
            char bukva_poslednaya = slovo[dlinya_slovya-1];
            if (bukva_odin==bukva_poslednaya)
            {
                Console.WriteLine("You can grabiyts capitalists");
            }
            else
            {
                Console.WriteLine("rastrelyats");
            }
        }
    }
}
