namespace GenericAttributes;

public class TypeAttribute : Attribute
{
    public TypeAttribute(Type t) => ParamType = t;

    public Type ParamType { get; }
}

public class TypeAttributeUsage
{
    [TypeAttribute(typeof(string))]
    public static string? Method() => default;
}

#region C#10 Preview, need <LangVersion>Preview</LangVersion> in csproj

public class GenericAttribute<T> : Attribute { }

public class GenericAttributeUsage
{
    [GenericAttribute<string>()]
    public static string? Method() => default;
}

#endregion