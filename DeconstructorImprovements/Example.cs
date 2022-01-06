namespace DeconstructorImprovements;

public struct TimeAndPlace
{
    public TimeOnly Time { get; set; }
    public string Place { get; set; }

    internal void Deconstruct(out TimeOnly time, out string place)
    {
        time = Time;
        place = Place;
    }
}

public class Example
{
    public static void Cs9Method()
    {
        #region C#9 and earlier ways to deconstruct an object

        var techTalk = new TimeAndPlace()
        {
            Time = new TimeOnly(10, 0),
            Place = "Slack"
        };

        TimeOnly time;
        string place;

        (time, place) = techTalk;

        // OR

        (var newTime, var newPlace) = techTalk;

        #endregion
    }

    public static void Cs10Method()
    {
        #region C#10 deconstruction allows mixing

        TimeOnly itsAlwaysAtTen = new(10, 0);

        var techTalk = new TimeAndPlace()
        {
            Time = itsAlwaysAtTen,
            Place = "Slack"
        };

        // Mixed operation
        (itsAlwaysAtTen, var thePlace) = techTalk;

        #endregion
    }
}