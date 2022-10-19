namespace EQIDL;

public class SliderDrawTemplate : Class {

    [XmlElement("Thumb", Type = typeof(ButtonDrawTemplate))]
    public ButtonDrawTemplate Thumb;

    [XmlElement("Background", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Background;

    [XmlElement("EndCapRight", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> EndCapRight;

    [XmlElement("EndCapLeft", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> EndCapLeft;

}