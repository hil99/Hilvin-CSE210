class Address {
    private readonly string _streetAddress = string.Empty;
    private readonly string _cityName = string.Empty; 
    private readonly string _stateCode = string.Empty;
    private readonly int _postalCode = default(int);
    private readonly string _countryName = string.Empty;

    public Address() { }

    public Address(string street, string city, string state, int zip, string country) {
        this._streetAddress = street;
        this._cityName = city;
        this._stateCode = state;
        this._postalCode = zip;
        this._countryName = country;
    }

    public string GetCountryName() {
        return _countryName;
    }

    public bool IsInUSA() {
        return _countryName.ToLower() == "usa"; // Case-insensitive check
    }

    public string FormatFullAddress() {
        return string.Join("", new string[] {
            $"\t{_streetAddress}\t\n",
            $"\t{_cityName}, {_stateCode} {_postalCode}\t\n",
            $"\t{_countryName}"
        });
    }
}
