class Customer {
    
    private Address _clientLocation = new Address();
    private string _clientName = "";
    private int _client = 0;

    

    public Address GetClientLocation() {
        return _clientLocation;
    }

    public bool IsInUSA() {
        return _clientLocation.IsInUSA();
    }
    public string GetClientName() {
        return _clientName;
    }

    public Customer(int client, string clientName, Address clientLocation) {
    _client = client; _clientName = clientName; _clientLocation = clientLocation;
}

   public Customer() : this(0, string.Empty, new Address()) { }



    public string PrintFormattedAddress() {
        return _clientLocation.FormatFullAddress();
    }
}

