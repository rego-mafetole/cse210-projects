using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product) => _products.Add(product);

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        double shipping = 0;
        {
            if (_customer.LivesInUsa())
            {
                shipping = 5.00;
            }
            else
            {

            }
        }
        return total + shipping;

    }

    public string GetPackingLabel()
    {
        string label = "---Packing Label---\n";
        foreach (Product product in _products)
        {
            label += product.GetPackingInfo() + "";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"---Shipping Label--- \n {_customer.GetName()} \n {_customer.GetFullAddress()}";
    }
}