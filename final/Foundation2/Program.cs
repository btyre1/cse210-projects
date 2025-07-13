using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address address1 = new Address("123 Maple Street", "Chicago", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", 101, 12.99, 2));
        order1.AddProduct(new Product("Pen", 102, 1.50, 5));

        Address address2 = new Address("456 King Road", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", 201, 8.75, 3));
        order2.AddProduct(new Product("Pencil", 202, 0.99, 10));

        Console.WriteLine("===== Order 1 =====");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost().ToString("F2"));

        Console.WriteLine("\n===== Order 2 =====");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost().ToString("F2"));
    }
}