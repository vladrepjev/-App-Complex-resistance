using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Model
{
    public class Inductor : ElectricalElementBase
    {
        private double _inductance;
        public long _multiplier;
        public double minValue = 0.000001;
        public double maxValue = 10;
        public string messageMinValue = "1 мкГн";
        public string messageMaxValue = "10 Гн";
        public string nameElement = "Индуктивность";

        public double Inductance
        {
            get
            {
                return _inductance;
            }
            set
            {
                _inductance = ValidationMethod(value, nameElement, minValue, maxValue, messageMinValue, messageMaxValue); //микрогенри
            }
        }

        public override long Multiplier
        {
            get
            {
                return _multiplier;
            }
            set
            {
                switch (value)
                {
                    case 0:
                        _multiplier = 1000000;
                        namePhysicalQuantity = "мкГн";
                        break;
                    case 1:
                        _multiplier = 1000;
                        namePhysicalQuantity = "мГн";
                        break;
                    case 2:
                        _multiplier = 1;
                        namePhysicalQuantity = "Гн";
                        break;
                }
            }
        }
       

        public override Complex CalculateImpedance(double valueElement)
        {
            Inductance = valueElement / Multiplier;
            return new Complex(0, Math.Round(2 * Math.PI * frequency * Inductance, 4));
        }
    }
}
