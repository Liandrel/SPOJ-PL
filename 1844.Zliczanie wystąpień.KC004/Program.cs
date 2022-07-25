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
            string ciag;
            do
            {
                ciag = Console.ReadLine();
                string[] dane = ciag.Split(' ');
                List<int> list = new List<int>();
                for (int i = 2; i < dane.Length; i++)
                    list.Add(int.Parse(dane[i]));
                List<int> list2 = list.FindAll(x => x == int.Parse(dane[0]));
                Console.WriteLine(list2.Count.ToString());
            }
            while (ciag != null);
        }
        catch (Exception ex)
        {
            Environment.Exit(0);
        }

    }
}
