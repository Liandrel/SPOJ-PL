class Program
{
    static void Main()
    {
        int ile = int.Parse(Console.ReadLine());

        for (int i = 0; i < ile; i++)
        {
            string dane = Console.ReadLine();
            string[] danet = dane.Split(' ');
            int a = Int32.Parse(danet[0]);
            int b = Int32.Parse(danet[1]);
            int wieksza, mniejsza, check;
            if (a > b)
            {
                wieksza = a;
                mniejsza = b;
            }
            else
            {
                wieksza = b;
                mniejsza = a;
            }
            int j = 2;
            check = wieksza;
            while(check % mniejsza != 0)
            {
                check = wieksza;
                check *= j;
                j++;
            }
            Console.WriteLine(check);
        }
    }
}