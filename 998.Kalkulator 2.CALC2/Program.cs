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
        string[] dane = new string[3];
        int[] data = new int[10];
        while((n = Console.ReadLine()) != null)
        {
            dane = n.Split(' ');
            switch (dane[0])
            {
                case "+":
                    Console.WriteLine(data[int.Parse(dane[1])] + data[int.Parse(dane[2])]);
                    break;
                case "-":
                    Console.WriteLine(data[int.Parse(dane[1])] - data[int.Parse(dane[2])]);
                    break;
                case "*":
                    Console.WriteLine(data[int.Parse(dane[1])] * data[int.Parse(dane[2])]);
                    break;
                case "/":
                    Console.WriteLine(data[int.Parse(dane[1])] / data[int.Parse(dane[2])]);
                    break;
                case "%":
                    Console.WriteLine(data[int.Parse(dane[1])] % data[int.Parse(dane[2])]);
                    break;
                case "z":
                    data[int.Parse(dane[1])] = int.Parse(dane[2]);
                    break;
            }
        }
    }
}
