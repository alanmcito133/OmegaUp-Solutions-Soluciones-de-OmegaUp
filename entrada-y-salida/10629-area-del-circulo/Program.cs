using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        double radio = double.Parse(Console.ReadLine());
        double area = Math.PI * (radio * radio);
        Console.WriteLine($"{area:F2}");
    }
}

