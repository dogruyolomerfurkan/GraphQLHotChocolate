using Microsoft.EntityFrameworkCore;

namespace GraphQLHotChocolate.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }
    public DbSet<Employee> Employees { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-KHS9OK4\\SQLEXPRESS;Database=Graphql;Trusted_Connection=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Employee>().Property(p => p.Id).ValueGeneratedNever();
        modelBuilder.Entity<Employee>()
            .HasData(
            new Employee { Id = 1, Name = "Ömer Furkan", Designation = "Designer" },
            new Employee { Id = 2, Name = "Ayşe", Designation = "Anything" },
            new Employee { Id = 3, Name = "Serdar", Designation = "Developer" }
            );
    }
}