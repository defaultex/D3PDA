namespace EQIDL;

public class GaugeDrawTemplate : Class {

    [XmlElement("Background", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Background;

    [XmlElement("Fill", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Fill;

    [XmlElement("Lines", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Lines;

    [XmlElement("LinesFill", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> LinesFill;

    [XmlElement("EndCapLeft", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> EndCapLeft;

    [XmlElement("EndCapRight", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> EndCapRight;

}