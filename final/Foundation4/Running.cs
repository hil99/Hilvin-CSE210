using System;

class Running : Activity

{
    protected override float CalculateSpeedInKph()
    {
        return (DistanceUnits / (float)Minutes) * 60;
    }
    protected override float CalculatePaceInMinutesPerKm()
    {
        return Minutes / (float)DistanceUnits;
    }
    public Running(int length, int distance, string date) : base(distance, date, length) {}

    protected override float CalculateDistanceInKilometers()
    {
        return DistanceUnits; 
    }

    

    
}