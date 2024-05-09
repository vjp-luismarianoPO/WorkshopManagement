namespace WorkshopManagement.Infrastructure.Data;

public partial class Supplier
{
	public int Id { get; set; }

	public string? Name { get; set; }

	public string? Phone { get; set; }

	public virtual ICollection<Accident> Accidents { get; set; } = new List<Accident>();
}
