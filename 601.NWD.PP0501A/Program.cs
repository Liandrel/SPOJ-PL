class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string dane = Console.ReadLine();
            string[] danetab = dane.Split(' ');
            int a = Int32.Parse(danetab[0]);
            int b = Int32.Parse(danetab[1]);
            while(a !=b)
            {
                if(a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine(a);
        }
    }
    
}