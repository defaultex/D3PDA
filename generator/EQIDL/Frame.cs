namespace EQIDL;

public class Frame : Class {
    [XmlElement("Texture", Type = typeof(UIReference<TextureInfo>))]
    public UIReference<TextureInfo> Texture;

    [XmlElement("Location", Type = typeof(Point))]
    [DefaultValue(default(Point))]
    public Point Location = default(Point);

    [XmlElement("Size")]
    [DefaultValue(default(Size))]
    public Size Size = default(Size);

    [XmlElement("Hotspot", Type = typeof(Point))]
    [DefaultValue(default(Point))]
    public Point Hotspot = default(Point);

    [XmlElement("Duration")]
    [DefaultValue(1000)]
    public int Duration = 1000;

    [XmlElement("Shading", Type = typeof(RGB))]
    [DefaultValue(default(RGB))]
    public RGB Shading = default(RGB);

    [XmlElement("Specular", Type = typeof(RGB))]
    [DefaultValue(default(RGB))]
    public RGB Specular = default(RGB);
}