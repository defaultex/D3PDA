namespace EQIDL;

public static class Extensionmethods {

    public static bool Contains<T>(this List<T> list, string name)
        where T : Class {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            if (list[i].Name == name) {
                return true;
            }
        }
        return false;
    }

    public static T Find<T>(this List<T> list, string name)
        where T : Class {
        T result = default(T);
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            if (list[i].Name == name) {
                result = list[i];
                break;
            }
        }
        return result;
    }
    
}