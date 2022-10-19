namespace EQIDL;

public class FrameDrawTemplate : Class {

    [XmlElement("TopLeft", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> TopLeft;

    [XmlElement("Top", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Top;

    [XmlElement("TopRight", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> TopRight;

    [XmlElement("BottomLeft", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> BottomLeft;

    [XmlElement("Bottom", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Bottom;

    [XmlElement("BottomRight", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> BottomRight;

    [XmlElement("LeftTop", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> LeftTop;

    [XmlElement("Left", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Left;

    [XmlElement("LeftBottom", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> LeftBottom;

    [XmlElement("RightTop", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> RightTop;

    [XmlElement("Right", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Right;

    [XmlElement("RightBottom", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> RightBottom;

    [XmlElement("Middle", Type = typeof(UIReference<Ui2DAnimation>))]
    public UIReference<Ui2DAnimation> Middle;

    [XmlElement("OverlapLeft")]
    [DefaultValue(0)]
    public int OverlapLeft = 0;

    [XmlElement("OverlapRight")]
    [DefaultValue(0)]
    public int OverlapRight = 0;

    [XmlElement("OverlapTop")]
    [DefaultValue(0)]
    public int OverlapTop = 0;

    [XmlElement("OverlapBottom")]
    [DefaultValue(0)]
    public int OverlapBottom = 0;
}