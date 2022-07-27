using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1911.Zliczanie_liczb_i_wyrazów.KC010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string data;
                do
                {
                    data = Console.ReadLine();
                    string[] datatable = data.Split(' ');
                    int liczby = 0, wyrazy = 0;
                    for(int i = 0; i < datatable.Length; i++)
                    {
                        if ((Regex.Match(datatable[i], "^[0-9]*$").Success))
                        {
                            liczby++;
                        }
                        else
                        {
                            wyrazy++;
                        }

                    }
                    Console.WriteLine($"{liczby} {wyrazy}");
                }
                while (data != "");
            }
            catch (Exception ex)
            {
                Environment.Exit(0);
            }
        }
    }
}
