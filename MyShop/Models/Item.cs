using System.ComponentModel.DataAnnotations;

namespace MyShop.Models
{
	public class Item
	{
		public int ItemId { get; set; }
		public string Name { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public string? Description { get; set; }
        public string? ImageUrl { get; set; }
		//navigation property
		public List<OrderItem>? OrderItems { get; set; }
	}
}

/*Note: List<Order>? Orders is a navigation property in the Customer class.
 * A navigation property in an entity class represents a relationship between 
 * enitites and allows you to navigate from one enitity to related entities.
 * In this case, the Orders property is a navigation property that represents
 * the relationship between a Customer and their associated Order entities.
 * By having the Orders property in the Customer class, you can easily
 * access all the orders that belong to a specific customer.
 * 
 */

