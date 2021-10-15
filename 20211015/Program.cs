using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211015
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1a();
            //feladat1b();
            //feladat2();
            //feladat3();
            Console.WriteLine("Enter");
            Console.ReadLine();

        }
        static void feladat1a()
        {
            Console.WriteLine("Add meg az oldalak értékét! ");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            double t;
            t = a * 2 + b * 2;
            Console.WriteLine("A téglalap kerülete {0}", t);


        }
        static void feladat1b()
        {
            Console.WriteLine("Add meg az oldalak értékét! ");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            double t;
            t = a * 2 * b * 2;
            Console.WriteLine("A téglalap területe {0}",t);
        }
        static void feladat2()
        {
        }
        static void feladat3()
        {
            Console.WriteLine("Adj meg egy számot 1 és 7 között! ");
            int szam = int.Parse(Console.ReadLine());
            switch (szam)
            {
                case 1:
                Console.WriteLine("Hétfő");
                    break;
                case 2:
                    Console.WriteLine("Kedd");
                    break;
                case 3:
                    Console.WriteLine("Szerda");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök");
                    break;
                case 5:
                    Console.WriteLine("Péntek");
                    break;
                case 6:
                    Console.WriteLine("Szombat");
                    break;
                case 7:
                    Console.WriteLine("Vasárnap");
                    break;

                default:
                    Console.WriteLine("Helytelen érték");
                    break;
            }
        }
        static void feladat4()
        {
            for (int i = 40; i < 111; i++)
            {

            }
        }
    }
}
