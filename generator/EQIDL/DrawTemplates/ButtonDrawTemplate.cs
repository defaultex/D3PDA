namespace EQIDL;

public class ButtonDrawTemplate : Class {

    [XmlElement("Normal", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Normal;

    [XmlElement("Pressed", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Pressed;

    [XmlElement("Flyby", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Flyby;

    [XmlElement("Disabled", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Disabled;

    [XmlElement("PressedFlyby", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> PressedFlyby;

    [XmlElement("PressedDisabled", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> PressedDisabled;

    [XmlElement("NormalDecal", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> NormalDecal;

    [XmlElement("PressedDecal", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> PressedDecal;

    [XmlElement("FlybyDecal", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> FlybyDecal;

    [XmlElement("DisabledDecal", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> DisabledDecal;

    [XmlElement("PressedFlybyDecal", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> PressedFlybyDecal;

    [XmlElement("PressedDisabledDecal", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> PressedDisabledDecal;
}