using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211109
{
    class Program
    {
        static void Main(string[] args)
        {
            //bitek();
            novekvo();
            Console.WriteLine("Enter");
            Console.ReadLine();
        }
        static void bitek()
        {
            //gyors módszer
            string[] beolvas = File.ReadAllLines("1_bitek.txt");
            Console.WriteLine("A beolvasott bitek száma: {0}", beolvas.Length);
            int[] bit = new int[beolvas.Length];
            for (int i = 0; i < bit.Length; i++)
            {
                bit[i]= int.Parse(beolvas[i]);
            }
            Console.WriteLine();
        }
        static void novekvo()
        {
            string egysor = File.ReadAllText("3_novekvo.txt");
            Console.WriteLine(egysor);
            //szóköz mentén/karakter)felbontjuk
            //sok kicsi szöveget kapunk --> string típusu tömb
            string[] darabok = egysor.Split(' ');
            int[] szamok = new int[darabok.Length];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = int.Parse(darabok[i]);
            }
            Console.WriteLine();
            Console.WriteLine(szamok.Sum());
            Console.WriteLine(szamok.Max());
            Console.WriteLine(szamok.Min());
            Console.WriteLine(szamok.Average());
        }
    }
}
