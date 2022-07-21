using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int n = int.Parse(Console.ReadLine());
        if (n <= 2)
        {
            if(n == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            
        }
        else 
        {
            for (int i = 1; i <= n; i = i + 2)
            {
                sb.Append(i + " ");
            }
            for (int i = 0; i <= n; i = i + 2)
            {
                sb.Append(i + " ");
            }
            Console.WriteLine(sb.ToString());
        }
       
    }
}
