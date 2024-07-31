namespace static_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Mycollege.collegeName="asss";
            //Mycollege.address=123;
            //Mycollege.Collegebranch();
            //Mycollege.collegetime();
            /*
            derivedclass myclass = new derivedclass();
            myclass.Animal();
            myclass.eagle();
            myclass.Fly();
            Employee employee = new Employee();
            employee.Exp=3;
            */
            derivedclass5 ass = new derivedclass5();
            ass.greeting();
            Console.ReadLine();
      



    }
    }
    //sttic class
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
            int number = address+12;
            Console.WriteLine(number);
            Console.WriteLine("computers");
        }
        public static void collegetime()
        {
            Console.WriteLine("qq");
        }
    }
    
}

//two parent class
class baseclass1
{
    public void Animal()
    {
        Console.WriteLine("Animal");
    }
}

interface i2
{
    void Fly();
}

class derivedclass : baseclass1, i2
{
    public void eagle()
    {
        Console.WriteLine("Eagle");
    }
    public void Fly()
    {
        Console.WriteLine("fly");
    }
}


//one parent two children class
class baseclass3
{
    public void Animal()
    {
        Console.WriteLine("animal");
    }
}

class derivedclass3 : baseclass3
{
    public void dog()
    {
        Console.WriteLine("Dog");
    }
}
  class derivedclass4 : derivedclass3
{
    public void Labrador()
    {
        Console.WriteLine("Labrodor");
    }
}  

//encapsulation //wrapping
public class Employee
{
    private int exp;
    public int Exp
    {
        get { return exp; }
        set { exp=value; }
    }
     

    
}
/// <summary>
/// overidding
/// </summary>
public class baseclass
{
    public virtual void greeting()
    {
        Console.WriteLine("Hello");
    }
}

public class derivedclass5 : baseclass
{
    public override void greeting()
    {
        Console.WriteLine("derived hello");

        
    }
}


