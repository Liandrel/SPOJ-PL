class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            string dane = Console.ReadLine();
            string[] danetab = dane.Split(' ');
            int wynik = 0;
            for (int j = 0; j < m; j++)
            {
                wynik += Int32.Parse(danetab[j]);
            }
            Console.WriteLine(wynik);
        }

    }
}
