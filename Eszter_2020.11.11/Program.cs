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
