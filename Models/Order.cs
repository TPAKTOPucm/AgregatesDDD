using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace AgregatesDDD.Models
{
    public class Order
    {
        public ProductList Products { get; set; }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus Status { get; set; }
        public Address Address { get; set; }
    }

    public class ProductList
    {
        public ProductList(IImmutableList<Product> products)
        {
            if (products.Count > 0)
                Value = products;
            else
                throw new ArgumentException("List can not be empty");
        }
        public IImmutableList<Product> Value { get; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class Address
    {
        [Required]
        public string City { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }
        public int HomeNumber { get; set; }
        public int? ApartmentNumber { get; set; }
    }

    public enum OrderStatus
    {
        Active = 0,
        Inactive = 1
    }
}
