namespace StructTypeImprovements;

public struct Rectangle
{
    public Rectangle(decimal height, decimal width)
    {
        Height = height;
        Width = width;
    }

    public decimal Height { get; set; }
    public decimal Width { get; set; }

    #region New in C#10 you can use parameterless constructors so long as everything gets set.

    public Rectangle()
    {
        Height = 10m;
        Width = 10m;
    }

    #endregion
}