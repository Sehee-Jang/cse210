public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.TotalPrice();
        }

        // Add Shipping Cost
        if (_customer.ISInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }

    // List the name and product id of each product in the order
    public string GetPackingLabel()
    {
        string packingLabel = "PACKING DETAIL\n";
        for (int i = 0; i < _products.Count; i++)
        {
            packingLabel += $"{i + 1}. {_products[i].GetName()} ".PadRight(30) + $"ID: {_products[i].GetProductId()}\n";
        }
        return packingLabel;
    }

    // List the name and address of the customer
    public string GetShippingLabel()
    {
        string shippingLabel = "SHIPPING DETAIL\n";
        string shippingAddress = "Customer: " + _customer.GetName() + "\n" + _customer.GetAddress().FullAddress();
        return shippingLabel + shippingAddress;
    }
}