using System;

class Program
{
    static void MakeCircle(double radius)
    {
        try
        {
            Circle c = new Circle(radius);
            Console.WriteLine(c);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Main()
    {
        double[] numbers = { 25, -20, 20, 10, 0 };

        foreach (double value in numbers)
        {
            MakeCircle(value);
        }
    }
}
