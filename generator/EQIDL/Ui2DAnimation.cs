namespace EQIDL;

public class Ui2DAnimation : Class {
    [XmlElement("Cycle")]
    [DefaultValue(false)]
    public bool Cycle = false;

    [XmlElement("Grid")]
    [DefaultValue(false)]
    public bool Grid = false;

    [XmlElement("Vertical")]
    [DefaultValue(false)]
    public bool Vertical = false;

    [XmlElement("CellWidth")]
    [DefaultValue(0)]
    public int CellWidth = 0;

    [XmlElement("CellHeight")]
    [DefaultValue(0)]
    public int CellHeight = 0;

    [XmlArray("Frames")]
    [XmlArrayItem("Frame", Type=typeof(Frame))]
    public List<Frame> Frames = new List<Frame>();
}