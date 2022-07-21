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
        string data;
        string[] n = new string[3];
        int a, b;

        while((data = Console.ReadLine()) != null)
        {
            n = data.Split(' ');
            a = int.Parse(n[1]);
            b = int.Parse(n[2]);
            switch(n[0])
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "%":
                    Console.WriteLine(a % b);
                    break;
            }
        }

    }
}
