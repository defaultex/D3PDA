namespace EQIDL;

public class UIReference<T> where T : Class {

    [XmlText]
    public string Name;

    [XmlIgnore]
    public T Element;
}

public class Class {
    [XmlAttribute("item")]
    public string Name { get; set; }
}