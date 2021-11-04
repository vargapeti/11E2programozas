using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211104
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            feladat3();
        }
        static void feladat1()
        {
            FileStream fs = new FileStream("kicsi.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 11; i++)
            {
                sw.WriteLine();
            }
            sw.Close();
            fs.Close();
            List<string> kiir = new List<string>();
            for (int i = 1; i < 10; i++)
            {
                kiir.Add(i.ToString());
            }
            File.WriteAllLines("kicsi.txt", kiir);
        }
        static void feladat2()
        {
            FileStream fs = new FileStream("négyzet.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 16; i++)
            {
                sw.WriteLine(i*i);
            }
            sw.Close();
            fs.Close();
        }
        static void feladat3()
        {

        }

    }
}


