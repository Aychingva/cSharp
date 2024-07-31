namespace abstarct_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0);
            circle.DisplayArea();
           
            
        }
    }
}
public abstract class Shape
{
    public abstract double Area();
    public void DisplayArea()
    {
        Console.WriteLine($"Area: {Area()}");
    }
}


public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double Area()
    {
        return 3.14*Radius*Radius;
    }
}