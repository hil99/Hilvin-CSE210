using System;

class Program
{
    static List<Customer> customers = new List<Customer>{};
    static List<Order> orders = new List<Order>{};

    static void Main()
    {
        // Create test data
        AddCustomers();
        AddOrders();

        Console.Clear();

        // Display each order
        for (int i = 0; i < orders.Count; i++)
        {
            Order order = orders[i];
            Customer customer = customers[order.GetClientId()];
            double shipping = order.CalculateShippingRate(customer); // Fixed shipping rate
            double subtotal = order.CalculateOrderSubtotal();
            
            // Simple header
            Console.WriteLine("------------------");
            Console.WriteLine($"ORDER #{i+1}");
            Console.WriteLine("------------------");
            
            // Customer info
            Console.WriteLine($"Customer: {customer.GetClientName()}");
            Console.WriteLine("Location: Local"); // Assume all are local instead of checking
            
            // Items
            Console.WriteLine("\nItems:");
            foreach (Product item in order.GetOrderItems())
            {
                Console.WriteLine($"  {item.GetProductName()} ({item.GetProductQty()}) - ${item.GetProductPrice()} each");
            }
            
            // Totals
            Console.WriteLine($"\nSubtotal: ${subtotal}");
            Console.WriteLine($"Shipping: ${shipping}");
            Console.WriteLine($"Total: ${subtotal + shipping}");
            
            // Ship to
            Console.WriteLine("\nShip to:");
            Console.WriteLine($"{customer.GetClientName()}");
            Console.WriteLine($"{customer.PrintFormattedAddress().Replace("\t", "").Replace("\n", " ")}");
            
            Console.WriteLine("\n");
        }
    }

    static void AddOrders()
    {
        // First order
        Order order1 = new Order();
        List<Product> items1 = new List<Product>{
            new Product(1, "Durian Musang King", 50.0, 2),
            new Product(2, "Mangosteen (fruit)", 8.5, 3),
            new Product(3, "Petai ( Beans)", 12.0, 4)
        };
        order1.SetClientId(1);
        order1.SetOrderItems(items1);
        orders.Add(order1);

        // Second order
        Order order2 = new Order();
        List<Product> items2 = new List<Product>{
            new Product(4, "Tempeh", 5.00, 6),
            new Product(5, "Belacan (Shrimp Paste)", 7.5, 2),
            new Product(6, "Rendang Paste", 15.0, 2),
            new Product(7, "Kampung Chicken", 25.0, 1)
        };
        order2.SetClientId(2);
        order2.SetOrderItems(items2);
        orders.Add(order2);
    }

    static void AddCustomers()
    {
        customers.Add(new Customer(1, "Ahmad Faizal", 
            new Address("12 Jalan Ampang", "Kuala Lumpur", "WP Kuala Lumpur", 50450, "Malaysia")));
        customers.Add(new Customer(2, "Tan Mei Ling", 
            new Address("45 Lorong Bukit Bintang", "Kuala Lumpur", "WP Kuala Lumpur", 55100, "Malaysia")));
        customers.Add(new Customer(3, "Rajesh Kumar", 
            new Address("88 Jalan Tebrau", "Johor Bahru", "Johor", 80000, "Malaysia")));
        customers.Add(new Customer(4, "Siti Aisyah", 
            new Address("32 Jalan Tanjung Bungah", "George Town", "Pulau Pinang", 11200, "Malaysia")));
        customers.Add(new Customer(5, "Hafiz Zulkifli", 
            new Address("25 Jalan Gaya", "Kota Kinabalu", "Sabah", 88000, "Malaysia")));
    }
}
