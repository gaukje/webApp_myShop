using System;

namespace MyShop.Models
{
    public class Item
    {
        public int ItemId { get; set; }     // The member variables must begin with upper case letters
        public String Name { get; set; } = string.Empty; // The strings and classes must be declared with default values (String.Empty)
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
