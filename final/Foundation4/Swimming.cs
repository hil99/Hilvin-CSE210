using System;

class Swimming : Activity
{    
    protected override float CalculatePaceInMinutesPerKm()
    {
        return 60 / CalculateSpeedInKph();
    }
    protected override float CalculateSpeedInKph()
    {
        return (CalculateDistanceInKilometers() / Minutes) * 60;
    }
    // Store laps as a property to maintain the original parameter structure
    private int Laps { get; }
    
    public Swimming(int length, string date, int laps) : base(laps, date, length)
    {
        Laps = laps;
    }
    
    
    protected override float CalculateDistanceInKilometers()
    {
        return (Laps * 50) / 1000f;
    }

    

    
}