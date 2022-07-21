class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string data = Console.ReadLine();
            string[] datat = data.Split(' ');
            int x = int.Parse(datat[0]);
            float y = int.Parse(datat[1]);
            int[] czas = new int[x];
            double d = 86400, ciastka = 0 ;
            float pudelka = 0;
            for (int j = 0; j < x;j++)
            {
                czas[j] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < x; j++)
            {
                ciastka += d / czas[j];
                ciastka = Math.Floor(ciastka);
            }
           ciastka = Math.Floor(ciastka);
            float ciastkaf = (float)ciastka;
            pudelka = ciastkaf / y;
            Console.WriteLine(Math.Ceiling(pudelka));
        }

    }
}
