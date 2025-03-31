using System;

class Product {
    // Item specifications
   private int _itemId;
    private string _itemName;
    private double _unitPrice;
    private int _quantity;


    public int ItemId => _itemId;
    public string ItemName => _itemName;
    public double UnitPrice => _unitPrice;
    public int Quantity => _quantity;

    // Data retrieval functions
    public int GetProductID() => _itemId;
    public string GetProductName() => _itemName;
    public double GetProductPrice() => _unitPrice;
    public int GetProductQty() => _quantity;
    // Constructor methods
    public Product() { }
    
    public Product(int itemId, string itemName, double unitPrice, int quantity) {
        _itemId = itemId;
        _itemName = itemName;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    // Business logic
    public double CalculateLineTotal() {return _unitPrice * _quantity;
    }
}
