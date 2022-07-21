class Program
{
    static void Main()
    {
        int ile = int.Parse(Console.ReadLine());

        for (int i = 0; i < ile; i++)
        {
            int n = int.Parse(Console.ReadLine());

            silnia(n);
        }
    }
    static void silnia(int n)
    {
        int silnia = 1;
        if (n <= 9)
        {
            for (int i = 1; i <= n; i++)
            {
                silnia *= i;
            }
            int j = silnia % 10;
            int d = silnia - j;
            d = d / 10;
            d = d % 10;
            Console.Write(d);
            Console.Write(" ");
            Console.WriteLine(j);
        }
        else
        {
            Console.WriteLine("0 0");
        }
        
    }
}