using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Model
{
    public abstract class ElectricalElementBase
    {
        public double frequency = 50;
        public string namePhysicalQuantity;
        public string nameElement;
        public double minValue;
        public double maxValue;
        public abstract long Multiplier { get; set; }
        public abstract Complex CalculateImpedance(double valueElement);

        public static double ValidationMethod(double valueElement, string nameElement, double minValue, double maxValue, string messageMinValue, string messageMaxValue)
        {
           
            if (valueElement < minValue)
            {
                throw new ArgumentException(nameElement + " должно быть больше " + messageMinValue);
            }
            if (valueElement > maxValue)
            {
                throw new ArgumentException(nameElement + " должно быть меньше " + messageMaxValue);
            }
            return valueElement;
        }
    }
}
