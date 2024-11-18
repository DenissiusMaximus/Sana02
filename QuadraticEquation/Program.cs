class Program
{
    public static void Main()
    {
        double a, b, c, D;
        double x1, x2;

        Console.WriteLine("Enter a");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter b");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter c");
        c = Convert.ToDouble(Console.ReadLine());

        if (a == 0)//bx + c = 0 => x = -c/b
        {
            x1 = -c / b;
            x2 = x1;
        }
        else if (b == 0)// ax**2 + c = 0 => x = sqrt(-c/a)
        {
            x1 = Math.Sqrt(-c / a);
            x2 = -1 * Math.Sqrt(-c / a);
        }
        else if (c == 0)// ax**2 + bx = 0 => x = 0, x = -b/a
        {
            x1 = 0;
            x2 = -b / a;
        }
        else
        {
            D = (b * b) - (4 * a * c);
            if (D < 0)
            {
                Console.WriteLine("No real roots");
                return;
            }

            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
        }

        if (x2 == x1)
            Console.WriteLine("x = " + x1);
        else
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");

    }
}
