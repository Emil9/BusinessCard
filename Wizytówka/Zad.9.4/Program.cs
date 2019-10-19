using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._9._4
{
    class Program
    {
        struct Dane
        {
            public string imie;
            public string email;
            public string tel;
            public int imie_d;
            public int email_d;
            public int tel_d;
        }
        static void Main(string[] args)
        {
            Dane d;
            int a = 0, d_imie, d_email, d_tel, i, j, n;
            Console.Write("Podaj imię i nazwisko: ");
            d.imie = " " + Console.ReadLine() + " ";
            Console.Write("Podaj e-mail: ");
            d.email = Console.ReadLine();
            Console.Write("Podaj numer telefonu: ");
            d.tel = " tel. "+ Console.ReadLine() + " ";
            d.imie_d = d.imie.Length;
            d.email_d = d.email.Length;
            d.tel_d = d.tel.Length;
            if (d.imie_d > d.email_d && d.imie_d > d.tel_d)
            {
                a = d.imie_d + 3;
            }
            if (d.email_d > d.imie_d && d.email_d > d.tel_d)
            {
                a = d.email_d + 3;
            }
            if (d.tel_d > d.email_d && d.tel_d > d.imie_d)
            {
                a = d.tel_d + 3;
            }
            d_imie = (a + 2) / 2 - d.imie_d / 2;
            d_tel = (a + 2) / 2 - d.tel_d / 2;
            d_email = (a + 2) / 2 - d.email_d / 2;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j <= d.email.Length + 11; j++)
                {
                    if (i == 0 || i == 4 || j == 0 || j == d.email.Length + 11)
                        Console.Write("*");
                    else if (i == 1 && j == d_imie)
                    {
                        Console.Write(d.imie);
                        j += d.imie_d - 1;
                    }
                    else if (i == 2 && j == d_email)
                    {
                        Console.Write(d.email);
                        j += d.email_d - 1; ;
                    }
                    else if (i == 3 && j == d_tel)
                    {
                        Console.Write(d.tel);
                        j += d.tel_d - 1;
                    }
                    else Console.Write(" ");
                }
                    Console.WriteLine("");
                }
            Console.ReadKey(true);
        }
    }
}
