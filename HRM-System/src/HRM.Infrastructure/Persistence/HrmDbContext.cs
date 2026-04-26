using HRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.Persistence;

public sealed class HrmDbContext(DbContextOptions<HrmDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Position> Positions => Set<Position>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HrmDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
