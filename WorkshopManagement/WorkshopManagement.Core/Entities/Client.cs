namespace WorkshopManagement.Infrastructure.Data;

public partial class Client
{
	public int Id { get; set; }

	public string? Name { get; set; }

	public string? Phone { get; set; }

	public string? Email { get; set; }

	public string? CarModel { get; set; }

	public int? CompanyId { get; set; }

	public int? AccidentId { get; set; }

	public virtual Accident? Accident { get; set; }

	public virtual ICollection<Accident> Accidents { get; set; } = new List<Accident>();

	public virtual Company? Company { get; set; }
}
