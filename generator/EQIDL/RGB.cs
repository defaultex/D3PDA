namespace EQIDL;

public class RGB : Class {
    [XmlElement("Alpha"), DefaultValue(255)]
    public int Alpha = 255;
    [XmlElement("R"), DefaultValue(0)]
    public int R = 0;
    [XmlElement("G"), DefaultValue(0)]
    public int G = 0;
    [XmlElement("B"), DefaultValue(0)]
    public int B = 0;
}