using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Core.Interfaces
{
	public interface IAccidentRepository
	{
		Task<IEnumerable<Accident>> GetAccidents();
		Task InsertAccident(Accident accident);
	}
}
