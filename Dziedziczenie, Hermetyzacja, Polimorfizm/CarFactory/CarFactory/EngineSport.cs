using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class EngineSport: Engine
    {
        public EngineSport() : base()
        {
            NameType = "Silnik sportowy";
            EnginePlusPower = 2000;
            EnginePlusSpeed = 200;
            WeightOfEngine = 200;
            FuelConsumptionPer100km = 8;

        }
    }

}
