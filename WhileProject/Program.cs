class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(CalculateA(n));
        Console.WriteLine(CalculateB(n));
        Console.WriteLine(CalculateC(n));
    }
    static double CalculateA(int n)
    {
        double result = 0;
        int i = 1;
        while (i <= n)
        {
            result += Math.Pow(-1, i) / (2 * i + 1);
            i++;
        }
        return result;
    }

    static double CalculateB(int n)
    {
        double result = 0;
        int i = 1;
        while (i <= n)
        {
            result += 1 + 1.0 / (i * i);
            i++;
        }
        return result;
    }
    static int Factorial(int num)
    {
        int result = 1;
        while (num > 1)
        {
            result *= num;
            num--;
        }
        return result;
    }

    static int CalculateC(int n)
    {
        int result = 0;
        int i = 1;
        while (i <= n)
        {
            result += Factorial(i);
            i++;
        }
        return result;
    }


}