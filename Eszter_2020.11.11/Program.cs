using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eszter_2020._11._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            Console.Write("Kérem adjon meg egy karaktert az angol ABC szerint: ");
            string karakter = Console.ReadLine().ToUpper();
            //string szam = CharToSMS(karakter);
            Console.WriteLine($"1. feladat: a beolvasott karakter száma: {CharToSMS(karakter)}");

            //2.feladat
            Console.Write("Kérem adjon meg egy szót: ");
            string szo = Console.ReadLine().ToUpper();
            string osszefuz = null;
            for (int i = 0;i<szo.Length;i++)
            {
                //osszefuz = CharToSMS(szo[i].ToString());
                osszefuz += CharToSMS(szo.Substring(i, 1));
            }
            Console.WriteLine($"2.feladat\n{osszefuz}");

            //3.feladat
            string[] beolvas = new string[600];
            StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\Desktop\2007-majus\szavak.txt");
            int n = 0;
            while (!olvas.EndOfStream)
            {
                //string sor = olvas.ReadLine();
                beolvas[n] = olvas.ReadLine();
                n++;
            }
            Console.WriteLine("3.feladat\nBeolvasás kész!");          
            olvas.Close();

            //4.feladat
            int leghosszabb = beolvas[0].Length;
            int csere = 0;
            for (int i = 1; i<n; i++)
            {
                if (leghosszabb < beolvas[i].Length)
                {                  
                    leghosszabb = beolvas[i].Length;
                    csere = i;
                }
            }
            Console.WriteLine($"4. feladat\nA leghosszabb szó {beolvas[csere]} hossza: {leghosszabb}");

            //5.feladat
            int darab = 0;
            for (int i = 0; i<n; i++)
            {
                if (beolvas[i].Length <= 5)
                {
                    darab++;
                }
            }
            Console.WriteLine($"5.feladat\nEnnyi rövid szó van a fájlban: {darab}");

            //6.feladat
            Console.WriteLine("6. feladat");
            string[] kodok = new string[n];
            StreamWriter ir = new StreamWriter(@"C:\Users\Rendszergazda\Desktop\2007-majus\kodok.txt");
            string osszefuzes = null;
            for (int i = 0;i<n;i++)
            {
                for (int k = 0; k<beolvas[i].Length;k++)
                {
                    //osszefuzes = osszefuzes + CharToSMS(beolvas[i][k].ToString());
                    osszefuzes += CharToSMS(beolvas[i][k].ToString().ToUpper());
                }
                ir.WriteLine(osszefuzes);
                kodok[i] = osszefuzes;
                osszefuzes = null;
            }           
            ir.Close();
            Console.WriteLine("Kiírás kész!");

            //7.feladat
            Console.Write("Kérem adjon meg egy számsort:");
            string szamsor = Console.ReadLine();
            for (int i = 0; i<n;i++)
            {
                if (kodok[i] == szamsor)
                {
                    Console.WriteLine($"{szamsor}-hoz tartozó szavak: {beolvas[i]}");
                }
            }

            //8.feladat
            string[] kodok_index = new string[n];//Létrehozok egy új tömböt
            for (int i=0;i<n;i++)
            {
                kodok_index[i] = kodok[i] + " " + i;
            }
            Array.Sort(kodok_index);//Listaelem sorbarendezése
            Array.Sort(kodok);
            bool volt = false;
            for (int i = 0;i<n-1;i++)
            {
                //1.lépés: szétválasztás
                string[] db = kodok_index[i].Split(' ');
                int index = int.Parse(db[1]);
                if (db[0] == kodok[i+1])
                {
                    Console.Write($"{beolvas[index]} : {db[0]}; ");
                    volt = true;
                }
                if(db[0] != kodok[i + 1] && volt)
                {
                    Console.Write($"{beolvas[index]} : {db[0]}; ");
                    volt = false;
                }
            }
            /*for (int i = 0;i<10;i++)
            {
                Console.WriteLine(kodok_index[i]);
            }*/
            Console.ReadKey();
        }

        //Függvény: 1 karaktert alakít át sms számmá
        static string CharToSMS(string kar)
        {
            if (kar == "A" || kar == "B" || kar == "C")
            {
                return "2";
            }
            else if (kar == "D" || kar == "E" || kar == "F")
            {
                return "3";
            }
            else if (kar == "G" || kar == "H" || kar == "I")
            {
                return "4";
            }
            else if (kar == "J" || kar == "K" || kar == "L")
            {
                return "5";
            }
            else if (kar == "M" || kar == "N" || kar == "O")
            {
                return "6";
            }
            else if (kar == "P" || kar == "Q" || kar == "R" || kar == "S")
            {
                return "7";
            }
            else if (kar == "T" || kar == "U" || kar == "V")
            {
                return "8";
            }
            else
            {
                return "9";
            }
        }


    }
}
