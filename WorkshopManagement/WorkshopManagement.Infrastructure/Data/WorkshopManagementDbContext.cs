using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WorkshopManagement.Infrastructure.Data.Configurations;

namespace WorkshopManagement.Infrastructure.Data;

public partial class WorkshopManagementDbContext : DbContext
{
	public WorkshopManagementDbContext()
	{
	}

	public WorkshopManagementDbContext(DbContextOptions<WorkshopManagementDbContext> options)
		: base(options)
	{
	}

	public virtual DbSet<Accident> Accidents { get; set; }

	public virtual DbSet<Client> Clients { get; set; }

	public virtual DbSet<Company> Companies { get; set; }

	public virtual DbSet<Supplier> Suppliers { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Workshop_Management_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new AccidentConfiguration());
		modelBuilder.ApplyConfiguration(new CompanyConfiguration());
		modelBuilder.ApplyConfiguration(new ClientConfiguration());
		modelBuilder.ApplyConfiguration(new SupplierConfiguration());

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
