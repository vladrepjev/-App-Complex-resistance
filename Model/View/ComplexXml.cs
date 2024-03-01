using System;
using System.Numerics;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

public class ComplexXml : IXmlSerializable
{
    public Complex Value { get; set; }


    public XmlSchema GetSchema()
    {
        return null;
    }

    public void ReadXml(XmlReader reader)
    {
        string value = reader.ReadElementContentAsString();
        string[] parts = value.Split('|');
        double real = double.Parse(parts[0]);
        double imaginary = double.Parse(parts[1]);
        Value = new Complex(real, imaginary);
    }

    public void WriteXml(XmlWriter writer)
    {
        writer.WriteString(Value.Real.ToString() +"|"+ Value.Imaginary.ToString());
    }
}
