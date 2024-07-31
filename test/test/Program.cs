using System.Runtime.CompilerServices;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

           
            
            for(int i = 1; i<=n; i++)
            {
                Student student = new Student(i);
                

            }
            float averagescore = Calculator.average();
            Console.WriteLine($"averegascore {averagescore}");
        }
    }
}

class Student
{
    private int id;
    private int taskcompleted;
    private int taskfailed;
    private int bonus;
    public float totalscore;
    public Student(int id)
        
    {
        this.id=id;
        taskcompleted=new Random().Next(0, 20);
        taskfailed=new Random().Next(0, 20-taskcompleted);
        bonus=new Random().Next(0, 5);
        totalscore=Calculator.calculatescore(taskcompleted, taskfailed, bonus);


    }
}


static class Calculator

{
    private static int count=0;
    private static float totalscore=0;
       
    public static float  calculatescore(int taskcompleted,int taskfailed,int bonus)
    {
        float score = taskcompleted-taskfailed+bonus*2;
        totalscore+=score;
        count++;
        return totalscore;

       
    }
    public static float average()
    {
        if (count==0)
        {
            return -1;
        }
        return totalscore/count;

    }

}