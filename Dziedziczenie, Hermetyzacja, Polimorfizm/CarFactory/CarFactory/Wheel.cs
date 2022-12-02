using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    public abstract class Wheel
    {
        private int _minusSpeed;
        private int _plusSpeed;
        private bool _offroad;
        private bool _buletProof;
        private int _plusWeight;

        public int MinusSpeed { get { return _minusSpeed; } set { _minusSpeed = value; } }
        public int PlusSpeed { get { return _plusSpeed; } set { _plusSpeed = value; } }
        public bool OffRoad { get { return _offroad; } set { _offroad = value; } }
        public bool BuletProof { get { return _buletProof; } set { _buletProof = value; } }
        public int PlusWeight { get { return _plusWeight; } set { _plusWeight = value; } }


    }
}
