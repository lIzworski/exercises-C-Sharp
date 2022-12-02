using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    public abstract class Car 
    {
        private bool engineIsWorking = false;
        private bool doIHaveEngine = false;
        private string engineType = "";
        private int _tankMax;
        private double _fuelIntank;
        private int _armor;
        private int _speed;
        private int _weight;
        private int _capacity;
        private int _howManyWheels;
        private int _howManySeats;
        Engine ?MyEngine = null;

        public List<Wheel> yourWheels = new List<Wheel>();
        public int Armor { get { return _armor; } set { _armor = value; } }
        public int Speed { get { return _speed; } set { _speed = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }
        public int Capacity { get { return _capacity; } set { _capacity = value; } }
        public int HowManyWheels { get { return _howManyWheels; } set { _howManyWheels = value; } }
        public int HowManySeats { get { return _howManySeats; } set { _howManySeats = value; } }
        public double FuelIntank { get => _fuelIntank; set => _fuelIntank = value; }
        public int TankMax { get => _tankMax; set => _tankMax = value; }
        public bool DoIHaveEngine { get => doIHaveEngine; set => doIHaveEngine = value; }
        public bool EngineIsWorking { get => engineIsWorking; set => engineIsWorking = value; }
        public Engine MyEngine1 { get => MyEngine; set => MyEngine = value; }

        public virtual void AddWheels(Wheel w1)
        {
            if (w1.BuletProof) { Armor += 10; }
            Speed += w1.PlusSpeed;
            Speed -= w1.MinusSpeed;
            Weight += w1.PlusWeight;
        }

        public virtual void AddEngine(Engine e1)
        {
            if (DoIHaveEngine == false)
            {
                MyEngine1 = e1;
                DoIHaveEngine = true;
                engineType = e1.NameType;
                Speed += e1.EnginePlusSpeed;
                Capacity += e1.EnginePlusPower;
                Weight += e1.WeightOfEngine;
            }
            else
            {
                Console.WriteLine("Masz juz silnik");
            }
        }
        public virtual void AddFuel(int howManyLiters)
        {
            if (howManyLiters > TankMax)
            {
                FuelIntank = TankMax;
                Weight += TankMax;
                Console.WriteLine($"\nZatankowałeś do pełna {FuelIntank}/{TankMax} \n");
            }
            else
            {
                FuelIntank += howManyLiters;
                Weight += howManyLiters;
                Console.WriteLine($"\nZatankowałeś pojazd, stan paliwa {FuelIntank}/{TankMax} \n");
            }
        }
        public virtual void ShowCarStats()
        {
            Console.WriteLine($"Max Predkość : {Speed}");
            Console.WriteLine($"typ silnika : {engineType}");
            Console.WriteLine($"Waga : {Weight}");
            Console.WriteLine($"Ilosc kół : {yourWheels.Count}");
            Console.WriteLine($"ładowność : {Capacity}");
            Console.WriteLine($"paliwo : {FuelIntank}/{TankMax}");
            Console.WriteLine($"opancerzenie : {Armor}");

        }
    }
}
