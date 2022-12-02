using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class EngineTruck: Engine
    {
        public EngineTruck() : base()
        {
            NameType = "Silnik cieżarówki";
            EnginePlusPower = 4000;
            EnginePlusSpeed = 100;
            WeightOfEngine = 300;
            FuelConsumptionPer100km = 30;
        }
    }
}
