using System.Data.Common;

namespace second
{
    internal class Program
     
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Dog d = new Dog();

            Console.WriteLine("Hello, World!");
   
    }
    class Animal
    {
        class Food : Dog
        {
            int weight;
        }
        protected internal  virtual void speak()
        {
            Console.WriteLine("...");
        }

    class Dog:Animal
     {
        protected internal override void speak()
         {
            Console.WriteLine("woof");
         }
        
    }
}
