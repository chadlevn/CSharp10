namespace StructTypeImprovements;

public class WithOperator
{
    public void Method()
    {
        var rectangle = new Rectangle(10m, 10m);

        #region C#10 now allows use of the "with" operator for structs

        var doubleWidthRectangle = rectangle with { Width = rectangle.Width * 2 };

        #endregion
    }
}