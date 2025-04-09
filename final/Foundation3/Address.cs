public class Address
{
    private string _line;
    private string _city;
    private string _province;
    private string _country;

    public Address(string line, string city, string province, string country)
    {
        _line = line;
        _city = city;
        _province = province;
        _country = country;
    }

   public (string Line, string City, string Province, string Country) GetComponents()
    => TupleToValueTuple(Tuple.Create(_line, _city, _province, _country));

private static (string, string, string, string) TupleToValueTuple(Tuple<string, string, string, string> tuple)
{
    return (tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
}

    public string Format()
    {
        return $"{_line} - {_city}, {_province} ({_country})";
    }
}


