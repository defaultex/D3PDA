namespace EQIDL;

public class TextRGB : Class {
    [XmlElement("Alpha"), DefaultValue(255)]
    public int Alpha = 255;
    [XmlElement("R"), DefaultValue(255)]
    public int R = 255;
    [XmlElement("G"), DefaultValue(255)]
    public int G = 255;
    [XmlElement("B"), DefaultValue(255)]
    public int B = 255;
}