namespace LambdaExpressionImprovements;

public class Example
{
    public void Method()
    {
        Func<string, int>? parseInt = (string s) => int.Parse(s);

        #region In C#10 func and action can be inferred

        var parseIntInferred = (string s) => int.Parse(s);

        #endregion
    }
}