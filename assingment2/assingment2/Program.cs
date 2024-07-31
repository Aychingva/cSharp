
 

namespace assigment2
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                FishingDepartment fishingDepartment = new FishingDepartment();
                BusinessDepartment businessDepartment = new BusinessDepartment();

                Fisher fisher = new Fisher("lale", 16, FisherSpecialty.Fishing);
                BusinessAnalyst businessAnalyst = new BusinessAnalyst("Ali", 18, BusinessAnalystTeam.Income);

                fishingDepartment.Hire(fisher);
                businessDepartment.Hire(businessAnalyst);

                fisher.Work(3);
                businessAnalyst.Work(3);

                Console.WriteLine($"Fisher's money: {fisher.Money}");
                Console.WriteLine($"Business Analyst's money: {businessAnalyst.Money}");

                fishingDepartment.FixBoat();
                businessDepartment.PayTaxes();

                Console.WriteLine($"Fishing department budget after fixing boat: {fishingDepartment.Budget}");
                Console.WriteLine($"Business department budget after paying taxes: {businessDepartment.Budget}");
            }
        }
        public interface IWorker
        {
            string Name { get; }
            int Salary { get; }
            int Money { get; }

            void Work(int hours);
        }

        public interface IDepartment
        {
            int Budget { get; }
            int NumberOfWorkers { get; }

            void Hire(IWorker worker);
            void Fire(IWorker worker);
        }

        public enum FisherSpecialty
        {
            Fishing,
            Loading,
            Captain
        }

        public enum BusinessAnalystTeam
        {
            Income,
            Taxing
        }

        public abstract class Worker : IWorker
        {
            public string Name { get; }
            public int Salary { get; }
            public int Money { get; protected set; }

            public Worker(string name, int salary)
            {
                Name = name;
                Salary = salary;
                Money = 0;
            }

            public abstract void Work(int hours);
        }

        public class Fisher : Worker
        {
            public FisherSpecialty Specialty { get; }

            public Fisher(string name, int salary, FisherSpecialty specialty) : base(name, salary)
            {
                Specialty = specialty;
            }

            public override void Work(int hours)
            {
                int earnedMoney = hours * Salary;
                switch (Specialty)
                {
                    case FisherSpecialty.Fishing:
                        earnedMoney *= 2;
                        break;
                    case FisherSpecialty.Loading:
                        earnedMoney *= 3;
                        break;
                    case FisherSpecialty.Captain:
                        earnedMoney *= 4;
                        break;
                }
                Money += earnedMoney;
            }
        }

        public class BusinessAnalyst : Worker
        {
            public BusinessAnalystTeam Team { get; }

            public BusinessAnalyst(string name, int salary, BusinessAnalystTeam team) : base(name, salary)
            {
                Team = team;
            }

            public override void Work(int hours)
            {
                int earnedMoney = hours * Salary;
                switch (Team)
                {
                    case BusinessAnalystTeam.Income:
                        earnedMoney *= 4;
                        break;
                    case BusinessAnalystTeam.Taxing:
                        earnedMoney *= 2;
                        break;
                }
                Money += earnedMoney;
            }
        }

        public class FishingDepartment : IDepartment
        {
            public int Budget { get; private set; }
            public int NumberOfWorkers { get; private set; }
            public int NumOfBoats { get; private set; }
            public int NumOfDamagedBoats { get; private set; }

            public FishingDepartment()
            {
                Random rnd = new Random();
                Budget = rnd.Next(5000, 10001);
                NumberOfWorkers = 0;
                NumOfBoats = rnd.Next(5, 11);
                NumOfDamagedBoats = rnd.Next(1, 4);
            }

            public void Hire(IWorker worker)
            {
                NumberOfWorkers++;
            }

            public void Fire(IWorker worker)
            {
                if (NumberOfWorkers > 0)
                    NumberOfWorkers--;
            }

            public void FixBoat()
            {
                if (NumOfDamagedBoats > 0)
                {
                    Random rnd = new Random();
                    int repairCost = rnd.Next(500, 1001);
                    Budget -= repairCost;
                    NumOfDamagedBoats--;
                    NumOfBoats++;
                }
            }
        }

        public class BusinessDepartment : IDepartment
        {
            public int Budget { get; private set; }
            public int NumberOfWorkers { get; private set; }
            public int MonthlyIncome { get; private set; }

            public BusinessDepartment()
            {
                Random rnd = new Random();
                Budget = rnd.Next(5000, 10001);
                NumberOfWorkers = 0;
                MonthlyIncome = rnd.Next(1000, 5001);
            }

            public void Hire(IWorker worker)
            {
                NumberOfWorkers++;
            }

            public void Fire(IWorker worker)
            {
                if (NumberOfWorkers > 0)
                    NumberOfWorkers--;
            }

            public void PayTaxes()
            {
                Random rnd = new Random();
                int taxAmount = rnd.Next(1000, 2001);
                Budget -= taxAmount;
            }
        }


    }