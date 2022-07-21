class Program
{
    static void Main()
    {
        string data = Console.ReadLine();
        string[] datat = data.Split(' ');  
        double r = double.Parse(datat[0]);
        double d = double.Parse(datat[1]);
        double W = Math.Sqrt(Math.Pow(r,2) - (Math.Pow((d/2),2)));
        double pi = 3.141592654;
        double S = pi * Math.Pow(W,2);
        Console.WriteLine(S);
    }
}
