using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Model
{
    public class Resistor : ElectricalElementBase
    {
        private double _resistance;
        public long _multiplier;
        public double minValue = 1;
        public double maxValue = 10000000;
        public string messageMinValue = "1 Ом";
        public string messageMaxValue = "10 МОм";
        public string nameElement = "Сопротивление";

        public double Resistance
        {
            get
            {
                return _resistance;
            }
            set
            {

                _resistance = ValidationMethod(value, nameElement, minValue, maxValue, messageMinValue, messageMaxValue);
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
                        _multiplier = 1;
                        namePhysicalQuantity = "Ом";
                        break;
                    case 1:
                        _multiplier = 1000;
                        namePhysicalQuantity = "кОм";
                        break;
                    case 2:
                        _multiplier = 1000000;
                        namePhysicalQuantity = "МОм";
                        break;
                }
            }
        }

        public override Complex CalculateImpedance(double valueElement)
        {
            Resistance = valueElement * Multiplier;
            return new Complex(Resistance, 0);
        }
    }
}
