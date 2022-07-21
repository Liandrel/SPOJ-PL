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
        string n;

        double A, B, C;
        while((n = Console.ReadLine()) != null)
        {
            {
                string[] data = n.Split(' ');
                A = double.Parse(data[0]);
                B = double.Parse(data[1]);
                C = double.Parse(data[2]);
                double delta = (B * B) - 4 * A * C;
                if(delta < 0 )
                {
                    Console.WriteLine("0");
                }
                else if (delta > 0)
                {
                    Console.WriteLine("2");
                }
                else
                {
                    Console.WriteLine("1");
                }

            }

        }

    }
}
