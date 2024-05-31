public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public decimal TotalPrice()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} (Product ID: {_productId}) (Quantity: {_quantity}) ";
        // packingLabel += $"{i + 1}. {_products[i].GetName()} ".PadRight(30) + $"ID: {_products[i].GetProductId()}\n";
    }
}