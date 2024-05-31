using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Cougar Blvd", "Provo", "Utah", "USA");
        Address address2 = new Address("456 Singal-ro", "Younin-si", "Gyeonggi-do", "Republic of Korea");
        Address address3 = new Address("789 Ross st", "Vancouver", "BC", "Canada");

        // Create customers
        Customer customer1 = new Customer("Jayd", address1);
        Customer customer2 = new Customer("Sehee", address2);
        Customer customer3 = new Customer("Kendrick", address3);

        // Create products
        Product product1 = new Product("PB&J Frooze Balls", "PJ123", 4.47m, 3);
        Product product2 = new Product("Atkins Protein Bars", "PTB341", 6.98m, 10);
        Product product3 = new Product("Stanley 30oz Tumbler", "TBL221", 35.99m, 1);

        // Create orders and add products to them
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product3);

        // Display order details
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("[ORDER 1]");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice()}");
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("[ORDER 2]");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalPrice()}");
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("[ORDER 3]");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order3.TotalPrice()}");
        Console.WriteLine("-------------------------------------------");
    }
}