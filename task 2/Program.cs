using System;

class Program
{
    static void Main(string[] args)
    {

        double radius = 5.0;
        double area = Circle.CalculateArea(radius);
        double perimeter = Circle.perimeter(radius);
        Console.WriteLine($"Circle with radius {radius}:");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
    }
}