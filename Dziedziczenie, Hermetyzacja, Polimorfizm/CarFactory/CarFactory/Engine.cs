using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    public abstract class Engine
    {
        private string nameType = "";
        private int _enginePlusPower;
        private int _enginePlusSpeed;
        private int _weightOfEngine;
        private int _fuelConsumptionPer100km;

        public string NameType { get => nameType; set => nameType = value; }
        public int EnginePlusPower { get { return _enginePlusPower; } set { _enginePlusPower = value; } }
        public int EnginePlusSpeed { get { return _enginePlusSpeed; } set { _enginePlusSpeed = value; } }
        public int WeightOfEngine { get { return _weightOfEngine; } set { _weightOfEngine = value; } }
        public int FuelConsumptionPer100km { get => _fuelConsumptionPer100km; set => _fuelConsumptionPer100km = value; }
    }
}
