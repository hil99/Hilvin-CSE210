public class Reception : Event
{
    private readonly string _email;

    public Reception(string name, string info, DateTime day, string hour, Address location, string email)
        : base(name, info, day, hour, location)
    {
        _email = string.IsNullOrWhiteSpace(email)
            ? "not_provided@hilxevents.com"
            : email.Trim();
    }

    
    private string BuildDetails()
    {
        var builder = new System.Text.StringBuilder();
        builder.AppendLine(GetStandardDetails());
        builder.AppendLine("RSVP at: " + _email);
        return builder.ToString().Trim();
    }
     public override string GetFullDetails()
    {
        return BuildDetails();
    }

    public string GetContact()
    {
        return _email;
    }

   

}
