using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        try
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] dane = Console.ReadLine().Split(' ');
                double a1, b1, a2, b2;
                a1 = int.Parse(dane[0]);
                b1 = int.Parse(dane[1]);
                a2 = int.Parse(dane[2]);
                b2 = int.Parse(dane[3]);
                double temp;
                if(a1 < b1)
                {
                    temp = a1;
                    a1 = b1;
                    b1 = temp;
                }
                if(a2 < b2)
                {
                    temp = a2;
                    a2 = b2;
                    b2 = temp;
                }
                    
                if (a1 > a2 && b1 > b2)
                {
                    Console.WriteLine("TAK");
                }
                else if( a1 <= a2 && b1 <= b2)
                {
                    Console.WriteLine("NIE");
                }
                else
                {
                    double d1, d2;
                    d1 = Math.Sqrt(a1 * a1 + b1 * b1);
                    d2 = Math.Sqrt(a2 * a2 + b2 * b2);
                    if(d1 <= d2)
                    {
                        Console.WriteLine("NIE");
                    }
                    else
                    {
                        double a, b, c;
                        a = 0.5 * a1 - Math.Sqrt(Math.Pow(0.5 * d2,2) - Math.Pow(0.5 * b1,2));
                        b = 0.5 * b1 - Math.Sqrt(Math.Pow(0.5 * d2, 2) - Math.Pow(0.5 * a1, 2));
                        c = Math.Sqrt(a * a + b * b);
                        if(c > b2)
                        {
                            Console.WriteLine("TAK");
                        }
                        else
                        {
                            Console.WriteLine("NIE");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Environment.Exit(0);
        }

    }
}
