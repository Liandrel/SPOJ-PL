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
        string s;
        int i = 0;
        string temp;
        Stack<string> sztos = new Stack<string>();
        while ((s = Console.ReadLine()) != null)
        {
            switch (s)
            {
                case "+":
                    temp = Console.ReadLine();
                    if (i < 10)
                    {
                        sztos.Push(temp);
                        Console.WriteLine(":)");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(":(");
                    }
                    break;
                case "-":
                    if(i >= 1)
                    {
                        Console.WriteLine(sztos.Pop());
                        i--;
                    }
                    else
                    {
                        Console.WriteLine(":(");
                    }
                    break;
            }
        }

    }
}
