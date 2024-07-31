using System;

namespace before_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Defender defender = new Defender(25, Region.Europe, 100, 80);
            Midfielder midfielder = new Midfielder(28, Region.Africa, 120, 90, Position.CM, 12);
            Attacker attacker = new Attacker(30, Region.America, 90, 15);

            // Perform actions
            defender.Play(90); // Defender plays for 90 minutes
            midfielder.Train(2); // Midfielder trains for 2 hours
            attacker.Run(3); // Attacker runs for 3 hours

            // Output energy levels after actions
            Console.WriteLine($"Defender Energy: {defender.Energy}");
            Console.WriteLine($"Midfielder Energy: {midfielder.Energy}");
            Console.WriteLine($"Attacker Energy: {attacker.Energy}");
        }

    }
    }
}


/*

enum SkinColor
{
    White,
    Black,
    Grey
}



enum AnimalType
{
    Crocodile=15,
    Lizard=10

}
abstract class Animal
{
    
    protected int Age { get; private set; }
    protected  SkinColor AnimalColor {get; set;}
    protected int Calories { get; set; }
    protected abstract void Talk();

    public Animal(int age,SkinColor animalColor,int calories)
    {
        Age=age;
        AnimalColor=animalColor;
        Calories=calories;
    }


    protected void Sleep(int hours)
    {
        Calories+=hours*20;
    }

    protected void Eat(int calories)
    {
        Calories+=calories;
    }
   

}


class Dog : Animal, IWalk
{
    private int Speed;
    public Dog(int age,SkinColor animalColor,int calories,int speed) : base(age, animalColor, calories)
    {
        this.Speed=speed;
    }

    protected override void Talk()
    {
        Console.WriteLine("Woof");
    }


    public void Walk(int hours)
    {
        Calories-=hours*Speed/2;
    }
}


class Reptile : Animal,ISwim,IWalk
{
    AnimalType ReptileType;
    public Reptile(int age,SkinColor animalColor,int calories,AnimalType reptiletype) : base(age, animalColor, calories)
    {
        this.ReptileType=reptiletype;
    }
    protected override void Talk()
    {
        Console.WriteLine("ssrr");

    }
    public void Walk(int hours)
    {
        Calories-=hours*(int)ReptileType;
    }

    public void Swim(int hours)
    {
        Calories-=hours*((int)ReptileType-5);
    }
}

class Fish : Animal,ISwim
{
    int Size;
    public Fish(int age, SkinColor animalColor, int calories, int size) : base(age, animalColor, calories)
    {
        this.Size=size;
    }
    protected override void Talk()
    {
        Console.WriteLine("...");
    }

    public void Swim(int hours)
    {
        Calories-=hours*Size;
    }
}

interface ISwim
{
    void Swim(int hours);
}

interface IWalk
{
    void Walk(int hours);
}
*/

enum Region
{
    Europe,
    Asia,
    Africa,
    America
}



enum Position
{
    CMD=5,
    CM=15,
    CAM=10
}
abstract class FootballPlayer
{
    protected int Age { get; set; }
   protected  Region Mainland{ get; set; }
    protected int Energy { get; set; }
    protected abstract void Play(int minutes);

    public FootballPlayer(int age, Region mainland, int energy)
    {
        Age=age;
        Energy=energy;
        Mainland=mainland;
    }

    protected void Sleep(int hours)
    {
        Energy-=hours*50;
    }

    protected void Eat(int calories)
    {
        Energy+=calories;
    }
}

class Defender : FootballPlayer,ITrain
{
   private int Tackling;
    public Defender(int age, Region mainland, int energy,int tackling) : base(age, mainland,energy)
    {
        this.Tackling=tackling;
    }

    protected override void Play(int minutes)
    {
        Energy-=minutes*5;
    }

    public void Train(int hours)
    {
        Tackling+=hours;
    }

}

class Midfielder : FootballPlayer,ITrain,IRun
  
{
    Position MDposition;
    private int  Tackling;
    private int Speed;
   public Midfielder(int age,Region region,int energy,int tackling,Position mdposition,int speed): base(age, region, energy)
    {
        this.MDposition=mdposition;
        this.Tackling=tackling;
        this.Speed=speed;
    }

    public void Train(int hours)
    {
        Tackling+=hours;
    }
    protected override void Play(int minutes)
    {
        Energy-=minutes*(int)MDposition;
    }

   public void Run(int hours)
    {
        Speed+=hours;
    }
}


class Attacker : FootballPlayer,IRun
{
    private int Speed;
    public Attacker(int age, Region region, int energy, int speed): base(age, region, energy)
    {
        this.Speed=speed;
    }
    protected override void Play(int minutes)
    {
        Energy-=minutes*20;
    }

   public void Run(int hours)
    {
        Speed+=hours;
    }

}


interface IRun
{
    void Run(int hours);

}


interface ITrain
{
    void Train(int hours);
}
