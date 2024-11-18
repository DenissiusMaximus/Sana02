class Program
{
    public static void Main()
    {
        int[] grades = new int[5];
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введіть оцінку студента: ");
            grades[i] = int.Parse(Console.ReadLine());
            sum += grades[i];
        }

        double average = sum / 5.0;

        if (average >= 50)
        {
            Console.WriteLine("Студент допущений до екзамену.");
        }
        else
        {
            Console.WriteLine("Студент не допущений до екзамену.");
        }
    }
}
