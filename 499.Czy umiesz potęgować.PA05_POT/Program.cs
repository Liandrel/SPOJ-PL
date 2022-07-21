class Program
{
    static void Main()
    {
        int ile = int.Parse(Console.ReadLine());

        for (int i = 0; i < ile; i++)
        {
            string data = Console.ReadLine();
            string[] subs = data.Split(' ');
            int n = Int32.Parse(subs[0]);
            int m = Int32.Parse(subs[1]);
            potega(n, m);
        }

    }
    static void potega(int n, int m)
    {
        n = n % 10;
        switch (n)
        {
            case 0:
                Console.WriteLine("0");
                break;
            case 1:
                Console.WriteLine("1");
                break;
            case 2:
                switch (m % 4)
                {
                    case 0:
                        Console.WriteLine("6");
                        break;
                    case 1:
                        Console.WriteLine("2");
                        break;
                    case 2:
                        Console.WriteLine("4");
                        break;
                    case 3:
                        Console.WriteLine("8");
                        break;
                }
                break;
            case 3:
                switch (m % 4)
                {
                    case 0:
                        Console.WriteLine("1");
                        break;
                    case 1:
                        Console.WriteLine("3");
                        break;
                    case 2:
                        Console.WriteLine("9");
                        break;
                    case 3:
                        Console.WriteLine("7");
                        break;
                }
                break;
            case 4:
                switch(m%2)
                {
                    case 0:
                        Console.WriteLine("6");
                        break;
                    case 1:
                        Console.WriteLine("4");
                        break;
                }
                break;
            case 5:
                Console.WriteLine("5");
                break;
            case 6:
                Console.WriteLine("6");
                break;
            case 7:
                switch (m % 4)
                {
                    case 0:
                        Console.WriteLine("1");
                        break;
                    case 1:
                        Console.WriteLine("7");
                        break;
                    case 2:
                        Console.WriteLine("9");
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;
                }
                break;
            case 8:
                switch (m % 4)
                {
                    case 0:
                        Console.WriteLine("6");
                        break;
                    case 1:
                        Console.WriteLine("8");
                        break;
                    case 2:
                        Console.WriteLine("4");
                        break;
                    case 3:
                        Console.WriteLine("2");
                        break;
                }
                break;
            case 9:
                switch (m % 2)
                {
                    case 0:
                        Console.WriteLine("1");
                        break;
                    case 1:
                        Console.WriteLine("9");
                        break;
                }
                break;
            case 10:
                Console.WriteLine("0");
                break;

        }
    }

}