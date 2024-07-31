using System.Net.Http.Headers;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine(Calculator.circle(5));
            Console.WriteLine(Calculator.square(4));
            Console.WriteLine(Calculator.rectangle(4, 5));
            Console.WriteLine(Calculator.triangle(3, 2));
        }

    }
}


static class Calculator
{
    static float pi = 3.14f; 
    public static double circle(float radius)
    {
        return pi*radius*radius;
    }
    public static double square(float a)
    {
        return a*a;
    }

    public static double rectangle(float a,float b)
    {
        return a*b;
    }
    public static double triangle(float a,float h)
    {
        return a*h/2;
    }
}
