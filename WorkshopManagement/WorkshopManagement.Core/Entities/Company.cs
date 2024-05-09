namespace WorkshopManagement.Infrastructure.Data;

public partial class Company
{
	public int Id { get; set; }

	public string? Name { get; set; }

	public virtual ICollection<Accident> Accidents { get; set; } = new List<Accident>();

	public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
