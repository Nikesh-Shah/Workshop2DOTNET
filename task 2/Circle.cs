using System;
using System.Reflection.Metadata;

class Circle
{
    public const double Pi = 3.14;

    public static double CalculateArea(double radius)
    {
        return Pi * radius * radius;
    }

    public static double perimeter(double radius)
    {
               return 2 * Pi * radius;
    }
     
}