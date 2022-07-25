using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        try
        {
            string dane;
            do
            {
                dane = Console.ReadLine();
                string[] danet = dane.Split(';');
                string imie = danet[0].Substring(6);
                if(!(Regex.Match(imie[0].ToString(), "^[A-Z]*$").Success))
                {
                    Console.WriteLine("0");
                    continue;
                }
                else if(imie.Length > 10)
                {
                    Console.WriteLine("0");
                    continue;
                }
                else if(!(Regex.Match(imie.Substring(1), "^[a-z]*$").Success))
                {
                    Console.WriteLine("0");
                    continue;
                }



                string nazwisko = danet[1].Substring(11);
                if (!(Regex.Match(nazwisko[0].ToString(), "^[A-Z]*$").Success))
                {
                    Console.WriteLine("1");
                    continue;
                }
                else if (imie.Length > 20)
                {
                    Console.WriteLine("1");
                    continue;
                }
                else if (!(Regex.Match(nazwisko.Substring(1), "^[a-z]*$").Success))
                {
                    Console.WriteLine("1");
                    continue;
                }



                string data = danet[2].Substring(11);
                string[] datat = data.Split('-');
                if(datat[0].Length > 4)
                {
                    Console.WriteLine("2");
                    continue;
                }
                else if(!(Regex.Match(datat[0], "^[0-9]*$").Success))
                {
                    Console.WriteLine("2");
                    continue;
                }
                else if(int.Parse(datat[0]) < 1900 || int.Parse(datat[0]) > 2000)
                {
                    Console.WriteLine("2");
                    continue;
                }
                if (datat[1].Length > 2)
                {
                    Console.WriteLine("2");
                    continue;
                }
                else if (!(Regex.Match(datat[1], "^[0-9]*$").Success))
                {
                    Console.WriteLine("2");
                    continue;
                }
                else if (int.Parse(datat[1]) < 1 || int.Parse(datat[1]) > 12)
                {
                    Console.WriteLine("2");
                    continue;
                }
                if (datat[2].Length > 2)
                {
                    Console.WriteLine("2");
                    continue;
                }
                else if (!(Regex.Match(datat[2], "^[0-9]*$").Success))
                {
                    Console.WriteLine("2");
                    continue;
                }
                else if (int.Parse(datat[2]) < 1 || int.Parse(datat[2]) > 31)
                {
                    Console.WriteLine("2");
                    continue;
                }
                Console.WriteLine("3");
            }
            while (dane != null);
        }
        catch (Exception ex)
        {
            Environment.Exit(0);
        }

    }
}
