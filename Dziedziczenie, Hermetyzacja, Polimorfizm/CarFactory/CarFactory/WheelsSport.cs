using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class WheelsSport : Wheel
    {
        public WheelsSport():base()
        {
            PlusSpeed = 5;
            PlusWeight = 5;
            BuletProof = false;
            OffRoad = false;
        }
    }
}
