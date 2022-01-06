namespace ExtendedPropertyPatterns;

public class DateRange
{
    // DateOnly and TimeOnly are new structs for .NET 6.
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public TimeOnly TimeOfDay { get; set; } = new TimeOnly(0, 0);
}

public class DateCheckerUtility
{
    public static bool StartsInJanuary(DateRange dateRange) => 
        dateRange is { StartDate: { Month: 1 } };

    #region With C#10 You can reference nested properties directly without the use of extra brackets.

    public static bool StartsAndEndsInJanuary(DateRange dateRange) =>
        dateRange is { StartDate.Month: 1 } and { EndDate.Month: 1 };

    #endregion 
}