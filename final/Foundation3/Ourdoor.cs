public class Outdoor : Event
{
    public string WeatherForecast { get; private set; }

    public Outdoor(string title, string description, DateTime date, string time, Address location, string forecast)
        : base(title, description, date, time, location)
    {
        PrepareOutdoorSettings(forecast);
    }

    private void PrepareOutdoorSettings(string forecast)
    {
        ApplyWeatherForecast(forecast);
    }

    private void ApplyWeatherForecast(string forecast)
    {
        if (string.IsNullOrWhiteSpace(forecast))
        {
            WeatherForecast = "Weather update coming soon.";
        }
        else
        {
            WeatherForecast = forecast.Trim();
        }
    }

    public override string GetFullDetails()
    {
        string details = GetStandardDetails(); 
        string forecast = string.IsNullOrWhiteSpace(WeatherForecast) 
            ? "N/A" 
            : WeatherForecast;

        return $"Event Type: Outdoor\n{details}\nForecast: {forecast}";
    }
}
