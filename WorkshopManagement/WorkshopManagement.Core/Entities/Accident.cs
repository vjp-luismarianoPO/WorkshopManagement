namespace WorkshopManagement.Core.Entities
{
	public class Accident
	{
		public int Id { get; set; }
		public string? Type { get; set; }
		public DateTime? Date { get; set; }
		public int CompanyId { get; set; }
		//public virtual Company? Company { get; set; }
		public float TotalAmount { get; set; }
		public string? ClientId { get; set; }
		//public virtual Client? Client { get; set; }
		public int SupplierId { get; set; }
		//public virtual Supplier? Supplier { get; set; }
	}
}
