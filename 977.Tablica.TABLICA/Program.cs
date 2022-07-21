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
        string[] data = Console.ReadLine().Split(' ');
        int i = 0;
        Stack<string> sztos = new Stack<string>();
        foreach(string s in data)
            sztos.Push(s);
            
        foreach(string s in data)
            Console.Write(sztos.Pop() + " ");
    }
}
