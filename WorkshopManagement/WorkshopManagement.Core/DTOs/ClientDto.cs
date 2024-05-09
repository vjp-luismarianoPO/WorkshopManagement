namespace WorkshopManagement.Core.DTOs
{
	public class ClientDto
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Phone { get; set; }

		public string? Email { get; set; }

		public string? CarModel { get; set; }

		public int? CompanyId { get; set; }

		public int? AccidentId { get; set; }
	}
}
