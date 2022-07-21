using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] dane = Console.ReadLine().Split(' ');
            int a = int.Parse(dane[0]);
            int b = int.Parse(dane[1]);
            int temp = 0;
            while(b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            Console.WriteLine(a*2);
        }

    }
}
