using System;
namespace Interface
{

    interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }

    class Car : IVehiculo
    {
        private int gasoline;

        public Car(int initialGasoline)
        {
            gasoline = initialGasoline;
        }

        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving.");
            }
        }

        public bool Refuel(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("The Car is out of gasoline");
                return false;
            }
            gasoline += amount;
            Console.WriteLine("Gasoline refueled. Current gasoline level: " + gasoline);
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of gasoline to refuel: ");
            int amount = int.Parse(Console.ReadLine());
            Car car = new Car(0);
            car.Refuel(amount);
            car.Drive();
        }
    }
}