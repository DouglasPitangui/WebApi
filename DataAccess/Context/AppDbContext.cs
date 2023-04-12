using DataAccess.Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
	public class AppDbContext : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{ }
		public AppDbContext()
		{ }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var connectionString = "server=localhost;database=filme;user=root;password=root";
			optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
		}
	}
}
