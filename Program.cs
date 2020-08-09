using System;

namespace AbstractClassAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Porsche porsche911 = new Porsche("Porsche 911", 4000);
            porsche911.PrintInformation();
            porsche911.Start();
            porsche911.Stop();
            porsche911.FastAccelerate();

            Console.WriteLine("------------------------------------");

            Tesla teslaS2020 = new Tesla("Tesla S 2020", 6000);
            teslaS2020.PrintInformation();
            teslaS2020.Start();
            teslaS2020.Stop();
            teslaS2020.Charge();

            Console.ReadLine();
        }
    }

    abstract class Car
    {
        protected string Model;
        protected decimal Price;
        protected Car(string model, decimal price)
        {
            Model = model;
            Price = price;
        }
        public void PrintInformation()
        {
            Console.WriteLine($"{Model} has price is ${Price}");
        }

        public abstract void Start();
        public abstract void Stop();
    }

    interface ISportCar
    {
        void FastAccelerate();
    }

    interface IElectricCar
    {
        void Charge();
    }

    class Porsche : Car, ISportCar
    {
        public Porsche(string Model, decimal Price) : base(Model, Price)
        {  }
        public override void Start()
        {
            Console.WriteLine($"{this.Model} starts with noise");
        }
        public override void Stop()
        {
            Console.WriteLine($"{this.Model} stops with noise");
        }
        public void FastAccelerate()
        {
            Console.WriteLine("Porsche911 can accelerate from 0 to 100km/h in 2.5 second");
        }
    }

    class Tesla : Car, IElectricCar
    {
        public Tesla(string Model, decimal Price) : base(Model, Price)
        {  }
        public override void Start()
        {
            Console.WriteLine($"{this.Model} starts in silence");
        }
        public override void Stop()
        {
            Console.WriteLine($"{this.Model} stops in silence");
        }
        public void Charge()
        {
            Console.WriteLine("Tesla S 2020 takes 12 hours to fully charge");
        }
    }
}
