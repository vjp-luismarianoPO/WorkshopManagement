using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Core.Interfaces
{
	public interface IClientRepository
	{
		Task<IEnumerable<Client>> GetClients();
		Task<Client> GetClient(int id);
		Task InsertClient(Client client);
	}
}
