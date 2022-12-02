using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class Amphibian : Car, TurnOnEngine, IDive
    {
        public Amphibian() : base()
        {
            FuelIntank = 0;
            TankMax = 200;
            Armor = 100;
            Speed = 0;
            Weight = 1800;
            Capacity = 1700;
            HowManyWheels = 0;
            HowManySeats = 5;
        }
        public override void AddWheels(Wheel w1)
        {
            base.AddWheels(w1);
            if (yourWheels.Count <= HowManyWheels)
            {
                yourWheels.Add(w1);
            }
            else
            {
                Console.WriteLine("nie możesz dodać więcej kół do amfibi.");
            }
        }
        public void TurnOnEngine()
        {
            if (DoIHaveEngine == true)
            {
                if (FuelIntank > 0)
                {
                    EngineIsWorking = true;
                    Console.WriteLine("Silnik odpalony.");
                }
                else
                {
                    Console.WriteLine("Nie masz paliwa");
                }
            }
            else
            {
                Console.WriteLine("Nie masz silnika");
            }
        }
        public void Drive(double howFar)
        {
            if (EngineIsWorking == true)
            {
                if (yourWheels.Count == 0)
                {
                    double x = howFar / 100;
                    if (x * MyEngine1.FuelConsumptionPer100km < FuelIntank)
                    {
                        Console.WriteLine("Jedziesz");
                        double xx = Math.Abs(x);
                        for (int i = 0; i < Math.Abs(x); i++)
                        {
                            Console.WriteLine($"{xx}");
                            Thread.Sleep(1000);
                            xx--;
                        }
                        Console.WriteLine("Dojechałęś");
                        FuelIntank -= x * MyEngine1.FuelConsumptionPer100km;
                    }
                    else
                    {
                        Console.WriteLine("Nie masz wystarczającej ilości paliwa.");
                    }
                }
                else
                {
                    Console.WriteLine("amfibia nie posiada kół");
                }
            }
            else
            {
                Console.WriteLine("Masz wyłączony silnik");
            }
         }
    }
}
