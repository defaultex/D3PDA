namespace EQIDL;

public class WindowDrawTemplate : Class {

    [XmlElement("Background", Type = typeof(UIReference<TextureInfo>))]
    public UIReference<TextureInfo> Background;

    [XmlElement("BackgroundDrawType")]
    [DefaultValue(0)]
    public int BackgroundDrawType = 0;

    [XmlElement("VSBTemplate", Type = typeof(ScrollbarDrawTemplate))]
    public ScrollbarDrawTemplate VSBTemplate;

    [XmlElement("HSBTemplate", Type = typeof(ScrollbarDrawTemplate))]
    public ScrollbarDrawTemplate HSBTemplate;

    [XmlElement("CloseBox", Type = typeof(ButtonDrawTemplate))]
    public ButtonDrawTemplate CloseBox;

    [XmlElement("QMarkBox", Type = typeof(ButtonDrawTemplate))]
    public ButtonDrawTemplate QMarkBox;

    [XmlElement("MinimizeBox", Type = typeof(ButtonDrawTemplate))]
    public ButtonDrawTemplate MinimizeBox;

    [XmlElement("MaximizeBox", Type = typeof(ButtonDrawTemplate))]
    public ButtonDrawTemplate MaximizeBox;

    [XmlElement("TileBox", Type = typeof(ButtonDrawTemplate))]
    public ButtonDrawTemplate TileBox;

    [XmlElement("Border", Type = typeof(FrameDrawTemplate))]
    public FrameDrawTemplate Border;

    [XmlElement("Titlebar", Type = typeof(FrameDrawTemplate))]
    public FrameDrawTemplate Titlebar;

}