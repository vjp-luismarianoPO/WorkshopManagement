﻿namespace WorkshopManagement.Infrastructure.Data;

public partial class Accident
{
	public int Id { get; set; }

	public string? Type { get; set; }

	public string? Date { get; set; } = DateTime.UtcNow.ToString();

	public int? CompanyId { get; set; }

	public double? TotalAmount { get; set; }

	public int? ClientId { get; set; }

	public int? SupplierId { get; set; }

	public virtual Client? Client { get; set; }

	public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

	public virtual Company? Company { get; set; }

	public virtual Supplier? Supplier { get; set; }
}
