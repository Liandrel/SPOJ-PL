class Program
{
    static void Main()
    {
        int ile = int.Parse(Console.ReadLine()); 
        
        for (int i = 0; i < ile; i++)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(liczbapierwsza(n));
        }
        
    }
    static string liczbapierwsza(int n)
    {
        if ((n == 2) || (n == 3))
        {
            return "TAK";
        }
        if ((n <= 1) || (n % 2 == 0) || (n % 3 == 0))
        {
            return "NIE";
        }
        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return "NIE";
            }
        }
        return "TAK";
    }
}