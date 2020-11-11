using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._11._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            Console.Write("Kérem adjon meg egy karaktert az angol ABC szerint: ");
            string karakter = Console.ReadLine();

        }

        //Függvény: 1 karakter alkít át sms számmá
        static string CharToSMS(string kar)
        {
            if (kar == "A" || kar == "B" || kar == "C")
            {
                return "2";
            }
        }
    }
}
