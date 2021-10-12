using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211012
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            feladat5();
            feladat6();
            feladat7();
            feladat8();
            feladat9();
            feladat10();
            Console.WriteLine("Sok puszi!");
            Console.ReadLine();

        }
        static void feladat1()
        {
            Console.WriteLine("Ez a program kiíratja a számokat 1-20 között egymás mellé.");
            int[] szamok = new int[20];
            for (int i = 0; i < 20; i++)
            {
                szamok[i] = i + 1;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0} ", szamok[i]);
            }
            Console.WriteLine("\nEnter");
            Console.ReadKey();
        }
        static void feladat2()
        {
            Console.WriteLine("Ez a program kiíratja a számokat 1-20 között egymás alá.");
            int[] szamok = new int[20];
            for (int i = 0; i < 20; i++)
            {
                szamok[i] = i + 1;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(szamok[i]);
            }
            Console.ReadKey();
        }
        static void feladat3()
        {
            Console.WriteLine("Ez a program kiíratja a számokat 15-92 között egymás mellé.");
            int i = 15;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 93);
        }
        static void feladat4()
        {
            Console.WriteLine("Ez a program kiírja 1-30 között a páros számokat.");
            int paratalan = 0;
            do
            {
                if (paratalan % 2 == 0)
                {
                    Console.Write("{0} ", paratalan);
                }
                paratalan++;
            }
            while (paratalan < 31);
            Console.WriteLine();

            for (int i = 0; i < 31; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
        static void feladat5()
        {
            Console.WriteLine("Adj meg egy számot: ");
        }
        static void feladat6()
        {

        }
        static void feladat7()
        {

        }
        static void feladat8()
        {

        }
        static void feladat9()
        {

        }
        static void feladat10()
        {

        }
    }    
}
