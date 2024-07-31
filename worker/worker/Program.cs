namespace worker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker()
            {
                Salary=10,
                Tiredness=0.2,
                Budget=100
            };
            worker.Work(5);
            Console.WriteLine($"Worker's budget after work: {worker.Budget}, Tiredness: {worker.Tiredness}");


        }
    }
}

class Worker
{
    public double Salary { get; set; }
    public double Tiredness { get; set; }
    public double Budget { get; set; }
    public bool IsAlive
    {
        get { return Tiredness<1; }
    }

    public void Work(int hours)
    {
        if (IsAlive)
        {
            Budget+=hours*Salary;
            Tiredness+=2*hours/10;
        }
    }

    public void Sleep(int hours)
    {
        Tiredness-=hours/10;
    }

}

class Accountant : Worker
{
    private double accountantsalary;
    public int experience { get; set; }
    public new double Salary
    {
        get { return accountantsalary+experience*2; }
        set { accountantsalary=value; }
    }

}


