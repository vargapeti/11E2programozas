using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211015_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat11();
            feladat12();
            Console.WriteLine("Enter");
            Console.ReadLine();
        }
        static void feladat11()
        {
            Console.WriteLine("Ez a program kiírja a számokat -30 és 30 között ötösével");
            for (int i = -30; i < 31; i = i + 5)
            {
                Console.Write("{0} ", i);
            }
        }
        static void feladat12()
        {

        }
    }
}
