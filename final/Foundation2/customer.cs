class Customer {
    private int _clientId = 0;
    private Address _clientLocation = new Address();
    private string _clientName = "";

    public string GetClientName() {
        return _clientName;
    }

    public Address GetClientLocation() {
        return _clientLocation;
    }

    public bool IsInUSA() {
        return _clientLocation.IsInUSA();
    }

   public Customer() : this(0, string.Empty, new Address()) { }

public Customer(int clientId, string clientName, Address clientLocation) {
    _clientId = clientId;
    _clientName = clientName;
    _clientLocation = clientLocation;
}


    public string PrintFormattedAddress() {
        return _clientLocation.FormatFullAddress();
    }
}
