
Console.WriteLine(new PhysicalContainer("Plastic", 5.0).ToString());
Console.WriteLine(new WoodContainer(5.0).ToString());

#region C#10 Sealed ToString Console.WriteLine Example

//Console.WriteLine(new SteelSixGallonBucket());

#endregion

// Inline record constructors are a C#9 feature.
internal record PhysicalContainer(string Material, double Volume)
{
    public override string ToString()
    {
        return $"A container of {Volume} gallons in size, made entirely of {Material}.";
    }
}

internal record WoodContainer(double Volume) : PhysicalContainer("Wood", Volume);

#region C#10 Sealed ToString

internal record SealedContainer(string Material, double Volume)
{
    public sealed override string ToString()
    {
        return $"A container of {Volume} gallons in size, made entirely of {Material}.";
    }
}

internal record SteelSixGallonBucket() : SealedContainer("Steel", 6.0);

#endregion