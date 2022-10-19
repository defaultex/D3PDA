namespace EQIDL;

public class SpellGemDrawTemplate : Class {

    [XmlElement("Holder", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Holder;

    [XmlElement("Background", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Background;

    [XmlElement("Highlight", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Highlight;
}