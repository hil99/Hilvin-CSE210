using System;

public abstract class Activity
{
    // Properties
    public DateTime ActivityDate { get; private set; }
    public int Minutes { get; set; }
    public int DistanceUnits { get; private set; }

    // Constructors
    protected Activity(int distanceUnits, DateTime activityDate, int minutes)
    {
        DistanceUnits = distanceUnits;
        ActivityDate = activityDate;
        Minutes = minutes;
    }

    protected Activity(int distanceUnits, string dateString, int minutes)
        : this(distanceUnits, ParseDateOrDefault(dateString), minutes)
    {
    }

    // Public methods
    public float GetDistance() => CalculateDistanceInKilometers();
    public float GetSpeed() => CalculateSpeedInKph();
    public float GetPace() => CalculatePaceInMinutesPerKm();

    public string GetSummary()
    {
        return string.Format("{0} {1} ({2} min): Distance {3} km, Speed: {4} kph, Pace: {5} min per km",
            ActivityDate.ToShortDateString(),
            this.GetType().Name,
            Minutes,
            GetDistance(),
            GetSpeed(),
            GetPace());
    }

    // Abstract methods to be implemented by derived classes
    protected abstract float CalculateDistanceInKilometers();
    protected abstract float CalculateSpeedInKph();
    protected abstract float CalculatePaceInMinutesPerKm();

    // Private helper
    private static DateTime ParseDateOrDefault(string dateString)
    {
        return DateTime.TryParse(dateString, out DateTime result)
            ? result
            : DateTime.Today;
    }
}

