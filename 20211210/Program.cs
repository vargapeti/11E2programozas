using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211210
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string ajtó;
            char asztal;
            int husz;
            double eger;
            bool logikai;
            Console.Write("Adj meg egy szót: ");
            Console.ReadLine();
            Console.Write("Kérek egy mondatot:");
            string mondat = Console.ReadLine();
            Console.Write("Adj meg egy karaktert:");
            char karakter = char.Parse(Console.ReadLine());
            Console.Write("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy számot: ");
            double valosszam = double.Parse(Console.ReadLine());
            Console.WriteLine("2*{0}={1}", valosszam, 2 * valosszam);
            Console.WriteLine("2*{0}={1}", valosszam, Math.PI * valosszam);
            Console.WriteLine("{0}*3={1}", valosszam, Math.Pow(valosszam, 3));
            Console.WriteLine("gyök:{0}={1}", valosszam, Math.Pow(valosszam, (double)1 / 2));
            Console.WriteLine("gyök:{0}={1:0.00}", valosszam, Math.Sqrt(valosszam));
            int véletlen = rnd.Next(10, 51);
            Console.WriteLine("véletlen: {0}", véletlen);
            if (szam % 2 == 0)
            {
                Console.WriteLine("A {0} páros", szam);
            }
            else
            {
                Console.WriteLine("A {0} páratlan", szam);
            }
            if (szam > 0)
            {
                Console.WriteLine("A {0} pozitív", szam);
            }
            else if (szam < 0)
            {
                Console.WriteLine("A {0} negatív", szam);
            }
            else
            {
                Console.WriteLine("A {0} nulla", szam);
            }
            Console.WriteLine("A szó {0} ennyi karakterből áll", ajtó.Length);
            string maganhangzok = "aáeéiíoóöőuű";
            int dbmh = 0;
            foreach (var item in mondat)
            {
                if (maganhangzok.Contains(item.ToString().ToLower()));
                {
                    dbmh++;
                }
            }
            Console.WriteLine("A magánhangók száma: {0}", dbmh);
            string[] darabok = mondat.ToLower().Split('e');
            Console.WriteLine("Az e-k száma: {0}", darabok.Length);
            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}

