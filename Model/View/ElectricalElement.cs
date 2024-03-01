using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Xml;
using System.Xml.Serialization;

namespace View
{
    [Serializable]
    public class ElectricalElement
    {
        public string ElectricalElementName { get; set ; }
        
        //[XmlIgnore]
       // public Complex ElectricalElementValue { get; set; }
        
        [XmlIgnore]
        public Complex ElectricalElementValueComlex { get { return ElectricalElementValue.Value; } }

        public ComplexXml ElectricalElementValue { get; set; }
    }
}
