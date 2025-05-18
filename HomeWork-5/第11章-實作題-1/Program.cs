using System;

class Program
{
    // Part 1 - Cube 方法多載
    static int Cube(int x)
    {
        return x * x * x;
    }

    static double Cube(double x)
    {
        return x * x * x;
    }

    // Part 2 - MinElement 方法多載
    static int MinElement(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    static int MinElement(int a, int b, int c, int d)
    {
        return Math.Min(MinElement(a, b, c), d);
    }

    static void Main(string[] args)
    {
        // 測試 Cube
        Console.WriteLine("Cube of 3 (int): " + Cube(3));         // 27
        Console.WriteLine("Cube of 2.5 (double): " + Cube(2.5));   // 15.625

        // 測試 MinElement
        Console.WriteLine("Min of 3, 8, 2: " + MinElement(3, 8, 2));         // 2
        Console.WriteLine("Min of 4, 1, 9, 5: " + MinElement(4, 1, 9, 5));   // 1
    }
}
