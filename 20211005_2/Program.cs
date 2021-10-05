using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005_2
{
    class Program
    {
        static void Main(string[] args)


        {
            //feladat1();
            //feladat2();
            //feladat3();
            feladat4();
            Console.WriteLine("Enter");
            Console.ReadLine();

        }
        static void feladat1()
        {
            Console.Write("Adj meg egy számot! ");
            Double szam = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (szam % 2 == 0)
            {
                Console.WriteLine(" A(z) {0} szám páros", szam);
            }
            else
            {
                Console.WriteLine(" A(z) {0} szám páratlan", szam);
            }

        }
        static void feladat2()
        {
            Console.Write("Adj meg egy számot! ");
            Double jel = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            int szam = 0;
            if (szam >= 0)
            {
                Console.WriteLine("A szám pozitív");
            }
            else
            {
                Console.WriteLine("A szám negatív vagy nulla");
            }
        }
        static void feladat3()
        {
            Console.Write("Add meg a kinti hőmérsékletet! ");
            Double homerseklet = Convert.ToDouble(Console.ReadLine());
            if (homerseklet > 0)
            {
                Console.WriteLine("Fagypont fölött");
            }
            else if (homerseklet < 0)
            {
                Console.WriteLine("Fagypont alatt");
            }
            else
            {
                Console.WriteLine("Nulla fok van");
            }
        }
        static void feladat4()
        {

        }
    }
}
