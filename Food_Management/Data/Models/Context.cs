using Microsoft.EntityFrameworkCore;

namespace Food_Management.Data.Models
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("server=LAPTOP-NJT7QHD1\\SQLEXPRESS01; database=DbCoreFood;integrated security=true;TrustServerCertificate = True;");
		}
		public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
