﻿namespace Pustok.Models
{
	public class OrderItem
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public int BookId { get; set; }
		public int Count { get; set; }
		public decimal SalePrice { get; set; }
		public decimal CostPrice { get; set; }
		public decimal DiscountPercent { get; set; }

		public Order Order { get; set; }
		public Book Book { get; set; }
	}
}
