using Microsoft.EntityFrameworkCore;


using zamowienia_app.Models;

namespace zamowienia_app.Data
{
	public class OrderManagementContext : DbContext
	{
		public OrderManagementContext(DbContextOptions<OrderManagementContext> options) : base(options) { }
	
	public DbSet<Products> Products {  get; set; }
	public DbSet<Users> Users { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }

	}
}
