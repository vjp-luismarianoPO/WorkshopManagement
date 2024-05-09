namespace WorkshopManagement.Core.DTOs
{
	public class AccidentDto
	{
		public int Id { get; set; }

		public string? Type { get; set; }

		public DateTime? Date { get; set; }

		public int? CompanyId { get; set; }

		public double? TotalAmount { get; set; }

		public int? ClientId { get; set; }

		public int? SupplierId { get; set; }
	}
}
