using WorkshopManagement.Core.Entities;
using WorkshopManagement.Core.Interfaces;

namespace WorkshopManagement.Infrastructure.Repositories
{
	public class AccidentRepository :IAccidentRepository
	{
		async Task<IEnumerable<Accident>> IAccidentRepository.GetAccidents()
		{
			var accidents = Enumerable.Range(1, 10).Select(x=> new Accident
			{
				Id = x,
				Type = $"{x}",
				Date = DateTime.Now,
				CompanyId = x,
				TotalAmount = x,
				ClientId = $"{x}",
				SupplierId = x
			});

			await Task.Delay(10);

			return accidents;
		}
	}
}
