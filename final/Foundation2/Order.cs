class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public double GetTotalCost()
    {
        double totalCost = 0.00;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalProductCost();
        }

        double shippingCost = 0.00;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5.00;
        }
        else
        {
            shippingCost = 35.00;
        }

        totalCost += shippingCost;

        return totalCost;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"Product Name: {product.GetName()}, Product ID: {product.GetProductID()}\n";
        }

        return label;
    }
    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}