using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1854.Godzina_chaosu.CHAOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                for(int i = 0; i < n; i++)
                {
                    Hour h = new Hour();
                    string[] dane = Console.ReadLine().Split(':');
                    h.hours = int.Parse(dane[0]);
                    h.minutes = int.Parse(dane[1]);
                    do
                    {
                        h.later();
                    }
                    while(!h.isPalindromic());
                    Console.WriteLine(h.toString(true));
                }
                
            }
            catch (Exception ex)
            {
                Environment.Exit(0);
            }
        }
    }

}
