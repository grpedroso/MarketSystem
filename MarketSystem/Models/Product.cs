using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketSystem.Models
{
    public class Product
    {
        string Name { get; set; }
        string? Description { get; set; }    
        double Price { get; set; }
        int Quantity { get; set; }
        string? Category { get; set; }

        public Product(string name, string description, double price, int quantity, string category)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Category = category;
        }

        public void RegisterProduct(Product product)
        {
            
        }
    }
}
