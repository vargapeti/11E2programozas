using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211111
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("karakterek.txt", Encoding.Default);
            int sorokszama = beolvas.Length;
            int oszlopszam = beolvas[0].Split(' ').Length;
            char[,] karakterek = new char[sorokszama, oszlopszam];
            for (int i = 0; i < sorokszama; i++)
            {
                string[] darabok = beolvas[i].Split(' ');
                for (int j = 0; j < oszlopszam; j++)
                {
                    karakterek[i, j] = char.Parse(darabok[j]);
                }
            }
            Console.WriteLine("Elemek száma: {0}", karakterek.Length);
            Console.WriteLine("Sorok száma: {0}", karakterek.GetLength(0));
            Console.WriteLine("Oszlopok száma: {0}", karakterek.GetLength(1));

            Console.WriteLine("Enter");
            Console.ReadLine();
        }
    }
}
