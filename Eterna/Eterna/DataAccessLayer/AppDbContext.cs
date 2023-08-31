using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.DataAccessLayer;
public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
	public DbSet<Position> Positions { get; set; }
	public DbSet<Employee> Employees { get; set; }
	public DbSet<Testimonial> Testimonials { get; set; }
	public DbSet<Feature> Features { get; set; }
	public DbSet<Client> Clients { get; set; }
	public DbSet<Setting> Settings { get; set; }
	public DbSet<Service> Services { get; set; }
    public DbSet<Slide> Slides { get; set; }
    public DbSet<Pricing> Pricings { get; set; }
	public DbSet<Detail> Details { get; set; }
	public DbSet<PricingDetail> PricingDetails { get; set; }
}