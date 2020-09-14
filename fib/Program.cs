using System;

class Program
{
    public static int Main()
    {
        Console.Write("Enter number from 1 up : ");
        int end = int.Parse(Console.ReadLine());
        int j = 1;
        for (int i = 1; i <= end; i += j)
        {
            Console.Write("{0} ", i);
            j = i - j;
        }
        Console.ReadKey();
        return 0;
    }
}
