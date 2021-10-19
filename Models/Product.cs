using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDemo.Models
{
    public class ProductRepository
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product { ProductId = 1, ProductName = "Convertible car" },
                new Product { ProductId = 2, ProductName = "Vintage car" },
                new Product { ProductId = 3, ProductName = "New Beetle" },
                new Product { ProductId = 4, ProductName = "Mercedes Benz" }
            };
        }
    }
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
