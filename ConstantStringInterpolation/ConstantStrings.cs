namespace ConstantStringInterpolation;

public class ConstantStrings
{
    public const string Home = "/Home";

    public const string Index = $"{Home}/Index";

    // String interpolation can now be used with constants so long as all variables are themselves constants.
}