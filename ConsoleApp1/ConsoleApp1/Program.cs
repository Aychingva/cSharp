namespace static class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mycollege.collegeName="asss";
            Mycollege.address=123;
            Mycollege.Collegebranch();
            Mycollege.collegetime();
        }
    }
}
public static class Mycollege
{
    public static string collegeName;
    public static int address;
    static Mycollege()
    {
        collegeName="abc";
    }
    public static void Collegebranch()

    {
        int number = address+2;
        Console.WriteLine(number);
        Console.WriteLine("computers");
    }
    public static void collegetime()
    {
        Console.WriteLine("qq");
    }
}
