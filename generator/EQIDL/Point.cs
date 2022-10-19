namespace EQIDL;

public class Point : Class {
    [XmlElement("X"), DefaultValue(0)]
    public int X = 0;
    [XmlElement("Y"), DefaultValue(0)]
    public int Y = 0;
}