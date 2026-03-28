using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

    }

    public class Order
    {
        private Customer _customer;
        private List<Product> _products;

        public Order(Customer customer, List<Product> products)
        {
            _customer = customer;
            _products = products;
        }

        
    }

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

        public decimal GetTotalCost()
        {
            return _price * _quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetProductId()
        {
            return _productId;
        }
    }

    public class Customer
    {
        private string _name;
        private string _address;

        public Customer(string name, string address)
        {
            _name = name;
            _address = address;
        }
    }

    public class Address
    {
        private string _street;
        private string _city;
        private string _stateProvince;
        private string _country;

        public Address(string street, string city, string stateProvince, string country)
        {
            _street = street;
            _city = city;
            _stateProvince = stateProvince;
            _country = country;
        }

        public bool IsUsa()
        {
            return _country.ToLower() == "usa";
        }

        public string GetFullAddress()
        {
            return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
        }
    }
}
    