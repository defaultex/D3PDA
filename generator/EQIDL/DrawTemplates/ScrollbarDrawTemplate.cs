namespace EQIDL;

public class ScrollbarDrawTemplate : Class {

    [XmlElement("UpButton", Type = typeof(ButtonDrawTemplate))]
    public ButtonDrawTemplate UpButton;

    [XmlElement("DownButton", Type = typeof(ButtonDrawTemplate))]
    public ButtonDrawTemplate DownButton;

    [XmlElement("Thumb", Type = typeof(FrameDrawTemplate))]
    public FrameDrawTemplate Thumb;
    
    [XmlElement("MiddleTextureInfo", Type = typeof(UIReference<TextureInfo>))]
    public UIReference<TextureInfo> MiddleTextureInfo;

    [XmlElement("MiddleTint", Type = typeof(RGB))]
    public RGB MiddleTint = default(RGB);

}