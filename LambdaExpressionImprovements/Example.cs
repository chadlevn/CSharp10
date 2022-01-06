namespace LambdaExpressionImprovements;

public class Example
{
    public void Method()
    {
        Func<string, int>? parseInt = (string s) => int.Parse(s);

        #region In C#10 func and action can be inferred

        var parseIntInferred = (string s) => int.Parse(s);

        #endregion

        #region Explicit return types can be declared, when unable to be infered. Previously this wouldn't compile.

        var objectReturnTypeFunction = object (bool boolean) => boolean == true ? 1 : "Hello there!";

        #endregion

        #region Attributes on lambdas

        var withAttributes = ([NumberAttribute(1)] int a, [NumberAttribute(2)] int b) => a + b;

        #endregion
    }
}

internal class NumberAttribute : Attribute
{
    public NumberAttribute(int number)
    { }
}