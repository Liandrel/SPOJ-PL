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
            string dane;
            do
            {
                dane = Console.ReadLine();
                string[] data = dane.Split(' ');
                List<double> list = new List<double>();
                for (int i = 0; i < data.Length; i++)
                {
                    list.Add(Double.Parse(data[i]));
                }
                list.Sort();
                if(list[0] + list[1] > list[2])
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            while (dane != null);
        }
        catch (Exception ex)
        {
            Environment.Exit(0);
        }

    }
}
