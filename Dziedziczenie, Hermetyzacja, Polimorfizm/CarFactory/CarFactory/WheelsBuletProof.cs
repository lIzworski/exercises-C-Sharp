using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class WheelsBuletProof : Wheel
    {
        public WheelsBuletProof() : base()
        {
            PlusSpeed = 0;
            PlusWeight = 15;
            BuletProof = true;
            OffRoad = false;
        }
    }
}
