class Order {
    private int _clientId;
    private List<Product> _itemsList = new List<Product>();
    
    // Constructors
    public Order() { }
    
    public Order(int clientId, List<Product> items) {
        _clientId = clientId;
        _itemsList = items;
    }
    
    
    public int GetClientId() {
        return _clientId;
    }
    
    public void SetClientId(int clientId) {
        _clientId = clientId;
    }
    
    public List<Product> GetOrderItems() {
        return _itemsList;
    }
    
    public void SetOrderItems(List<Product> items) {
        _itemsList = items;
    }


    public double CalculateOrderSubtotal() {
        double runningTotal = 0;
        foreach(Product item in GetOrderItems()) {
            runningTotal += item.CalculateLineTotal();                              
        }
        return runningTotal;
    } 

    public string GeneratePackingList() {
    
    System.Text.StringBuilder packingBuilder = new System.Text.StringBuilder();
    
    
    string[] headers = { "ITEM #", "DESCRIPTION", "QTY", "UNIT PRICE" };
    Console.WriteLine($"{headers[0]}\t{headers[1].PadRight(25)}\t{headers[2]}\t{headers[3]}");
    
    
    foreach(Product item in GetOrderItems()) {
        packingBuilder.AppendLine($"\t{item.GetProductID()}\t{item.GetProductName()}\t\t{item.GetProductQty()}\t{item.GetProductPrice()}");
    }
    
    return packingBuilder.ToString();
}

   public string CreateShippingLabel(Customer client) {
    string labelText = ""; labelText += "\t*****************************\n"; labelText += "\t" + client.GetClientName() + "\n"; labelText += client.PrintFormattedAddress() + "\n"; labelText += "\t*****************************\n"; return labelText;
}

    public double CalculateShippingRate(Customer client) {
    if (client.GetClientLocation().GetCountryName().ToLower() == "usa") {
        return 5.0;  // Domestic shipping cost
    } else {
        return 35.0; // International shipping cost
    }
}   
}