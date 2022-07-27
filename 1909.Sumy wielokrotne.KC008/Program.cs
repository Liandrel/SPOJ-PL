using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1909.Sumy_wielokrotne.KC008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> wszystkie = new List<long>();
            long sumawszystkich = 0;
            try
            {
                string data = "";
                do
                {
                    data = Console.ReadLine();
                    long suma = 0;
                    string[] datatable = data.Split(' ');

                    foreach (string s in datatable)
                        suma += long.Parse(s);
                    Console.WriteLine(suma);
                    wszystkie.Add(suma);
                }
                while (data != null);
            }
            catch (Exception ex)
            {
                foreach (var s in wszystkie)
                    sumawszystkich += s;
                Console.WriteLine(sumawszystkich);
                Console.ReadLine();
            }
        }
    }
}
