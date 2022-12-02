using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class WheelsOffRoad : Wheel
    {
        public WheelsOffRoad() : base()
        {
            PlusSpeed = 0;
            PlusWeight = 10;
            BuletProof = false;
            OffRoad = true;
        }
    }
}
