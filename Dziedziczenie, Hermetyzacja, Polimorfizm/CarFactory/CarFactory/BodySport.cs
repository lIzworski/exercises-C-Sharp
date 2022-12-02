using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    public class BodySport : Car, TurnOnEngine, IDive
    {
        public BodySport() :base ()
        {
            FuelIntank = 0;
            TankMax = 50;
            Armor = 30;
            Speed = 0;
            Weight = 900;
            Capacity = 200;
            HowManyWheels = 4;
            HowManySeats = 2;
        }
        public override void AddWheels(Wheel w1)
        {
            base.AddWheels(w1);
            if(yourWheels.Count <= HowManyWheels)
            {
                yourWheels.Add(w1);
            }
            else
            {
                Console.WriteLine("nie możesz dodać więcej kół do samochodu.");
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
        public override void ShowCarStats()
        {
            Console.WriteLine();
            Console.WriteLine("Nadwozie sportowe");
            base.ShowCarStats();
            Console.WriteLine();
        }
        public void Drive(double howFar)
        {
            if(EngineIsWorking == true)
            {
                if (yourWheels.Count == 4)
                {
                    double x = howFar / 100;
                    if (x * MyEngine1.FuelConsumptionPer100km < FuelIntank)
                    {
                        Console.WriteLine("Jedziesz");
                        double xx = Math.Abs(x);
                        for(int i = 0; i < Math.Abs(x); i++) {
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
                    Console.WriteLine("Musisz miec 4 koła żebyś mógł jechać");
                }

            }
            else
            {
                Console.WriteLine("Masz wyłączony silnik");
            }
        }
    }
}
