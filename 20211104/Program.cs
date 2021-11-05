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
        static Random rmd = new Random();
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat7();
            //feladat8();
            //feladat9();
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
                sw.WriteLine(i * i);
            }
            sw.Close();
            fs.Close();
        }
        static void feladat3()
        {

        }
        static void feladat4()
        {
            FileStream fs = new FileStream("vércsoportok.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 51; i++)
            {
                switch (rmd.Next(1, 5))
                {
                    case 1:
                        sw.Write("A ");
                        break;
                    case 2:
                        sw.Write("B ");
                        break;
                    case 3:
                        sw.Write("AB ");
                        break;
                    case 4:
                        sw.Write("0 ");
                        break;
                    default:
                        break;
                }
            }
            sw.Close();
            fs.Close();
            for (int i = 1; i < 51; i++)
            {
                switch (rmd.Next(1, 5))
                {
                    case 1:
                        File.AppendAllText("vércsoportok2.txt", "A ");
                        break;
                    case 2:
                        File.AppendAllText("vércsoportok2.txt", "B ");
                        break;
                    case 3:
                        File.AppendAllText("vércsoportok2.txt", "AB ");
                        break;
                    case 4:
                        File.AppendAllText("vércsoportok2.txt", "0 ");
                        break;
                    default:
                        break;
                }
            }
        }
        static void feladat7()
        {
            FileStream fs = new FileStream("vércsoportok2rh.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 51; i++)
            {
                switch (rmd.Next(1, 5))
                {
                    case 1:
                        if (rmd.Next(1, 3) == 1)
                        {

                        }
                        else
                        {

                        }
                        break;
                    case 2:
                        sw.Write("B ");
                        break;
                    case 3:
                        sw.Write("AB ");
                        break;
                    case 4:
                        sw.Write("0 ");
                        break;
                    default:
                        break;
                }
            }
            sw.Close();
            fs.Close();
            for (int i = 1; i < 51; i++)
            {
                switch (rmd.Next(1, 5))
                {
                    case 1:
                        File.AppendAllText("vércsoportok2rh.txt", "A ");
                        if (rmd.Next(1, 3) == 1)
                        {
                            File.AppendAllText("vércsoportok2rh.txt", "RH+ \r");
                        }
                        else
                        {
                        File.AppendAllText("vércsoportok2rh.txt", "RH- \r");
                        }
                        break;
                    case 2:
                        File.AppendAllText("vércsoportok2rh.txt", "B ");
                        if (rmd.Next(1, 3) == 1)
                        {
                            File.AppendAllText("vércsoportok2rh.txt", "RH+ \r");
                        }
                        else
                        {
                            File.AppendAllText("vércsoportok2rh.txt", "RH- \r");
                        }
                        break;
                    case 3:
                        File.AppendAllText("vércsoportok2rh.txt", "AB ");
                        if (rmd.Next(1, 3) == 1)
                        {
                            File.AppendAllText("vércsoportok2rh.txt", "RH+ \r");
                        }
                        else
                        {
                            File.AppendAllText("vércsoportok2rh.txt", "RH- \r");
                        }
                        break;
                    case 4:
                        File.AppendAllText("vércsoportok2rh.txt", "0 ");
                        if (rmd.Next(1, 3) == 1)
                        {
                            File.AppendAllText("vércsoportok2rh.txt", "RH+ \r");
                        }
                        else
                        {
                            File.AppendAllText("vércsoportok2rh.txt", "RH- \r");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        static void feladat8()
        {
            //ez a program kiirat 20 hajszint 
            FileStream fs = new FileStream("hajszin.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 21; i++)
            {
                switch (rmd.Next (1,5))
                {
                    case 1:
                        sw.Write("Barna ");
                        break;
                    case 2:
                        sw.Write("Szőke ");
                        break;
                    case 3:
                        sw.Write("Vörös ");
                        break;
                    case 4:
                        sw.Write("Fekete ");
                        break;
                    case 5:
                        sw.Write("Ősz ");
                        break;
                    default:
                        break;
                }
            }
            sw.Close();
            fs.Close();
        }
        static void feladat9()
        {
            //ez a program kiirat 25 telefonmárkát
            FileStream fs = new FileStream("telefonmarka.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 26; i++)
            {
                switch (rmd.Next(1,5))
                {
                    case 1:
                        sw.Write("Apple ");
                        break;
                    case 2:
                        sw.Write("Samsung ");
                        break;
                    case 3:
                        sw.Write("Huawei ");
                        break;
                    case 4:
                        sw.Write("Nokia ");
                        break;
                    case 5:
                        sw.Write("Sony ");
                        break;
                    default:
                        break;
                }
            }
            sw.Close();
            fs.Close();
        }
    }
}


