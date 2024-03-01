using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Model
{
    public class Capacitor : ElectricalElementBase
    {

        private double _capacitance;
        public long _multiplier;
        public double minValue = 0.000000000001;
        public double maxValue = 0.01;
        public string messageMinValue = "1 пФ";
        public string messageMaxValue = "10000 мкФ";
        public string nameElement = "Емкость";

        public double Capacitance { 
            get
            {
                return _capacitance;
            }
            set 
            {

                _capacitance = ValidationMethod(value, nameElement, minValue, maxValue, messageMinValue, messageMaxValue);
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
                        _multiplier = 1000000000000;
                        namePhysicalQuantity = "пФ";
                        break;
                    case 1:
                        _multiplier = 1000000000;
                        namePhysicalQuantity = "нФ";
                        break;
                    case 2:
                        _multiplier = 1000000;
                        namePhysicalQuantity = "мкФ";
                        break;
                }
            }
        }

        public override Complex CalculateImpedance(double valueElement)
        {
            Capacitance = valueElement / Multiplier;
            return new Complex(0, Math.Round(-1 / (2 * Math.PI * frequency * Capacitance), 4));
        }
    }
}
