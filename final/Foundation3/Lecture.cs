public class Lecture : Event
{
    public string Host { get; private set; }
    public int MaxSeats { get; private set; }

    public Lecture(string name, string info, DateTime day, string hour, Address location, string hostName, int seats)
        : base(name, info, day, hour, location)
    {
        InitLecture(hostName, seats);
    }

    private void InitLecture(string hostName, int seats)
    {
        Host = string.IsNullOrWhiteSpace(hostName) ? "TBA" : hostName;
        MaxSeats = seats > 0 ? seats : 50;
    }

    public override string GetFullDetails()
    {
        return string.Format("{0}\n" +
                             "---------------------\n" +
                             "SPEAKER: {1}\n" +
                             "CAPACITY: {2} seats",
                             GetStandardDetails(),
                             Host,
                             MaxSeats);
    }
}
