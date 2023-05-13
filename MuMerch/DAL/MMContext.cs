using DAL.Entities;
using System.Data.Entity;

namespace DAL
{
    public class MMContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductColorMap> ProductColorMaps { get; set; }
        public DbSet<ProductOrderMap> ProductOrderMaps { get; set; }
        public DbSet<ProductSizeMap> ProductSizeMaps { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<BandManager> BandManagers { get; set; }
        public DbSet<Gig> Gigs { get; set; }
        public DbSet<GigManager> GigManagers { get; set; }
        public DbSet<Token> Tokens { get; set; }
    }
}
