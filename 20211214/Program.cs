using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211214
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string wau;
            char szemuveg;
            int husz;
            double nem;
            bool ok;
            Console.WriteLine("Adj meg egy szót: ");
            string szó = Console.ReadLine();
            Console.WriteLine("Kérek egy mondatot: ");
            string mondat = Console.ReadLine();
            Console.WriteLine("Adj meg egy karaktert: ");
            char karakter = char.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy egész számot: ");
            int szám = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy valós számot: ");
            double vszám = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", vszám*2);
            Console.WriteLine("{0}", Math.PI*vszám);
            Console.WriteLine("{0}", Math.Pow(vszám, 3));
            Console.WriteLine("{0}", (vszám, (double) 1/2));
            int véletlen = rnd.Next(10, 51);
            Console.WriteLine("véletlen:{0}", véletlen);
            Console.WriteLine("Kérek egy számot: ");
            int megadottszam=int.Parse(Console.ReadLine());
            if (megadottszam % 2 == 0)
            {
                Console.WriteLine("A szám páros.");
            }
            else
            {
                Console.WriteLine("A szám páratlan");
            }
            Console.WriteLine("Kérek egy számot: ");
            int megadottszam2 = int.Parse(Console.ReadLine());
            if (megadottszam2 >0)
            {
                Console.WriteLine("A szám pozitiv");
            }
            else if (megadottszam2 <0)
            {
                Console.WriteLine("A szám negatív");
            }
            else
            {
                Console.WriteLine("Nulla");
            }
            Console.WriteLine("Adj meg egy számot: ");
            int megadottszam3 = int.Parse(Console.ReadLine());
            if (megadottszam3 <30)
            {
                Console.WriteLine("A szám 30-nál nagyobb");
            }
            else if (megadottszam3 >30)
            {
                Console.WriteLine("A szám 30-nál kisebb");
            }
            else
            {
                Console.WriteLine("A szám 30");
            }
            Console.WriteLine("Adj meg két számot: ");
            int megadottszam4 =int.Parse(Console.ReadLine());
            int megadottszam5 =int.Parse(Console.ReadLine());
            if (megadottszam4<megadottszam5)
            {
                Console.WriteLine("{0} A nagyobb", megadottszam5);
            }
            else
            {
                Console.WriteLine("{0} A nagyobb", megadottszam4);
            }
            Console.WriteLine("Adj meg két számot: ");
            int megadottszam6 = int.Parse(Console.ReadLine());
            int megadottszam7 = int.Parse(Console.ReadLine());
            if (megadottszam6 > megadottszam7)
            {
                Console.WriteLine("{0} A kisebb", megadottszam7);
            }
            else
            {
                Console.WriteLine("{0} A kisebb", megadottszam6);
            }
            Console.WriteLine("Adj meg egy szót: ");
            string szav = Console.ReadLine();
            Console.WriteLine("A szó {0} karakter hosszú", szav.Length);
            Console.WriteLine("Adj meg egy szót: ");
            string puszi = Console.ReadLine();
            int dbmh = 0;
            foreach (var item in mondat)
            {
                if (puszi.Contains('e')) 
                {
                    dbmh++;
                }
            }
            Console.WriteLine("A szóban {0} e betű van.", dbmh);
            Console.WriteLine("Adj meg egy szót: ");
            string nemtudom = Console.ReadLine();
            Console.WriteLine("A szó {0} karakterből áll", nemtudom.Length);
            string maganhangzok = "aáeéiíoóöőuű";
            dbmh = 0;
            foreach (var item in mondat)
            {
                if (maganhangzok.Contains(item.ToString().ToLower())) ;
                {
                    dbmh++;
                }
            }
            Console.WriteLine("A szóban {0} magánhangzó van.", dbmh);
            Console.WriteLine("Adj meg egy mondatot: ");
            string róka = Console.ReadLine();
            Console.WriteLine("A mondat {0} karakterből áll.", róka.Length);
            Console.ReadKey();
            Console.WriteLine("Adj meg egy mondatot: ");
            string árvíztűrő = Console.ReadLine();
            foreach (var item in árvíztűrő)
            {
                if (árvíztűrő.Contains(' '))
                {
                    dbmh1++;
                }
            }
            Console.WriteLine("");

        }
    }
}
