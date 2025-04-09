using System;

class Cycling : Activity
{
    // Constructor that passes values to the base Activity constructor
    public Cycling(int durationInMinutes, string activityDate, int distanceCovered)
        : base(distanceCovered, activityDate, durationInMinutes)
    {
    }

    // Calculates total distance in kilometers
    protected override float CalculateDistanceInKilometers()
    {
        float kilometers = DistanceUnits;
        return kilometers;
    }

    // Calculates speed in kilometers per hour
    protected override float CalculateSpeedInKph()
    {
        float totalKilometers = CalculateDistanceInKilometers();
        float totalHours = Minutes / 60f;

        float speed = totalKilometers / totalHours;
        return speed;
    }

    // Calculates pace in minutes per kilometer
    protected override float CalculatePaceInMinutesPerKm()
    {
        float pace = Minutes / CalculateDistanceInKilometers();
        return pace;
    }
}
