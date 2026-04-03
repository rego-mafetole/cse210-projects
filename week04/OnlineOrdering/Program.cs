using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("145 Joe St", "Idaho", "ID", "USA");
        Customer cust1 = new Customer("Joseph Smith", address1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "C101", 950.00, 1));

        Address address2 = new Address("602 Maple Ln", "London", "Greater London", "UK");
        Customer cust2 = new Customer("Alexandra Hams", address2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Phone Case", "P500", 15.00, 2));

        Address address3 = new Address("245 Llama St", "Sydney", "ID", "USA");
        Customer cust3 = new Customer("Amber Mafetole", address3);
        Order order3 = new Order(cust3);
        order3.AddProduct(new Product("Laptop Case", "C155", 20.00, 1));

        DisplayOrderResults(order1);
        DisplayOrderResults(order2);
        DisplayOrderResults(order3);
    }

    static void DisplayOrderResults(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Order price: ${order.CalculateTotalPrice():0.00}");
        Console.WriteLine(new string('-', 30));
    }
}
