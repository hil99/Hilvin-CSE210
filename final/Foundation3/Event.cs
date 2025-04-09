public abstract class Event
{
    public string Name { get; }
    public string Info { get; }
    public DateTime Day { get; }
    public string Hour { get; }
    public Address Location { get; }

    public Event(string name, string info, DateTime day, string hour, Address location)
    {
        var id = Guid.NewGuid().ToString("N").Substring(0, 8);
        Console.WriteLine($"Creating event {id}: {name}");

        Name = name.Trim();
        Info = string.IsNullOrEmpty(info) ? "No description" : info;
        Day = day.Date;
        Hour = hour;
        Location = location;

        Console.WriteLine($"Event {id} created for {Day:d}");
    }

    public virtual string GetStandardDetails()
    {
        return string.Format("EVENT: {0}\n" +
                             "---------------------\n" +
                             "DESCRIPTION: {1}\n" +
                             "---------------------\n" +
                             "DATE & TIME: {2} | {3}\n" +
                             "---------------------\n" +
                             "LOCATION: {4}",
                             Name.ToUpper(),
                             Info,
                             Day.ToString("ddd, MMM d, yyyy"),
                             Hour,
                             Location.Format());
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription()
    {
        return string.Format("EVENT TYPE: {0} | TITLE: {1} | DATE: {2}",
                             GetType().Name,
                             Name,
                             Day.ToString("MM/dd/yyyy"));
    }
}
