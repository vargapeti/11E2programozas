using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211008
{
    class Program
    {
        static void Main(string[] args)
        {
            //mintafeladat();
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void mintafeladat()
        {
            Console.WriteLine("Kávéautómata");
            Console.WriteLine("A: espresso");
            Console.WriteLine("B: latte macchiato");
            Console.WriteLine("C: espresso macchiato");
            Console.WriteLine("D: cappuchino");
            Console.WriteLine("E: bécsi kávé");
            Console.WriteLine("F: ristretto");
            Console.WriteLine("G: forró csoki");
            Console.Write("Válassz egy terméket! (A-G): ");
            char valasztas = char.Parse(Console.ReadLine());
            switch (valasztas)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Az espresso ára 130 ft.");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("A latte macchiato ára 150 ft.");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Az espresso macchitao ára 140 ft.");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("A cappuchino ára 130 ft.");
                    break;
                case 'E':
                case 'e':
                    Console.WriteLine("A bécsi kávé ára 150 ft.");
                    break;
                case 'F':
                case 'f':
                    Console.WriteLine("A ristretto ára 140 ft.");
                    break;
                case 'G':
                case 'g':
                    Console.WriteLine("A forró csoki ára 140 ft.");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen lehetőség.");
                    break;
            }

            switch (valasztas.ToString().ToLower())
            {
                case "a":
                    Console.WriteLine("Az espresso ára 130 ft.");
                    break;
                case "b":
                    Console.WriteLine("A latte macchiato ára 150 ft.");
                    break;
                case "c":
                    Console.WriteLine("Az espresso macchitao ára 140 ft.");
                    break;
                case "d":
                    Console.WriteLine("A cappuchino ára 130 ft.");
                    break;
                case "e":
                    Console.WriteLine("A bécsi kávé ára 150 ft.");
                    break;
                case "f":
                    Console.WriteLine("A ristretto ára 140 ft.");
                    break;
                case "g":
                    Console.WriteLine("A forró csoki ára 140 ft.");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen lehetőség.");
                    break;
            }
        }
        static void feladat1()
        {
            Console.Write("Adj meg egy számot!:");
            int honap = Int32.Parse(Console.ReadLine());

            switch (honap)
            {
                case 1:
                    Console.WriteLine("Január");
                    break;
                case 2:
                    Console.WriteLine("Február");
                    break;
                case 3:
                    Console.WriteLine("Március");
                    break;
                case 4:
                    Console.WriteLine("Április");
                    break;
                case 5:
                    Console.WriteLine("Május");
                    break;
                case 6:
                    Console.WriteLine("Június");
                    break;
                case 7:
                    Console.WriteLine("Július");
                    break;
                case 8:
                    Console.WriteLine("Augusztus");
                    break;
                case 9:
                    Console.WriteLine("Szeptember");
                    break;
                case 10:
                    Console.WriteLine("Október");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen hónap");
                    break;
            }
        }
        static void feladat2()
        {
            Console.Write("Adj meg egy számot! ");
            int honap = Int32.Parse(Console.ReadLine());
            switch (honap)
            {
                case 1:
                    Console.WriteLine("Tél");
                    break;
                case 2:
                    Console.WriteLine("Tél");
                    break;
                case 3:
                    Console.WriteLine("Tavasz");
                    break;
                case 4:
                    Console.WriteLine("Tavasz");
                    break;
                case 5:
                    Console.WriteLine("Tavasz");
                    break;
                case 6:
                    Console.WriteLine("Nyár");
                    break;
                case 7:
                    Console.WriteLine("Nyár");
                    break;
                case 8:
                    Console.WriteLine("Nyár");
                    break;
                case 9:
                    Console.WriteLine("Ősz");
                    break;
                case 10:
                    Console.WriteLine("Ősz");
                    break;
                case 11:
                    Console.WriteLine("Ősz");
                    break;
                case 12:
                    Console.WriteLine("Tél");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen hónap");
                    break;

            }
        }
        static void feladat3()
        {
            string input;
            do
            {
                Console.Write("Adj meg egy számot: ");
                input = Console.ReadLine();
            } while (long.Parse(input) > 2000000000);

            switch (input.Length)
            {
                case 1:
                    Console.WriteLine(" Egyjegyű.");
                    break;
                case 2:
                    Console.WriteLine(" Kétjegyű.");
                    break;
                case 3:
                    Console.WriteLine(" Háromjegyű.");
                    break;
                case 4:
                    Console.WriteLine(" Négyjegyű.");
                    break;
                case 5:
                    Console.WriteLine(" Ötjegyű.");
                    break;
                default:
                    Console.WriteLine(" Hatjegyű vagy annál több");
                    break;
            }
        }
        static void feladat4()
        {
            Console.Write("Add meg az osztályzatot! ");
            int osztalyzat = Int32.Parse(Console.ReadLine());
            switch (osztalyzat)
            {
                case 1:
                    Console.WriteLine("A tanfolyamot nem végezte el");
                    break;
                case 2:
                    Console.WriteLine("A tanfolyamot sikeresen elvégezte");
                    break;
                case 3:
                    Console.WriteLine("A tanfolyamot sikeresen elvégezte");
                    break;
                case 4:
                    Console.WriteLine("A tanfolyamot sikeresen elvégezte");
                    break;
                case 5:
                    Console.WriteLine("A tanfolyamot sikeresen elvégezte");
                    break;
                default:
                    Console.WriteLine("Nem létező osztalyzat");
                    break;
            }
        }
    }
}
