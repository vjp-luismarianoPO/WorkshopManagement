using Microsoft.EntityFrameworkCore;
using WorkshopManagement.Core.Interfaces;
using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Infrastructure.Repositories
{
	public class ClientRepository : IClientRepository
	{
		private readonly WorkshopManagementDbContext _context;
		public ClientRepository(WorkshopManagementDbContext context)
		{
			_context = context;
		}
		public async Task<IEnumerable<Client>> GetClients()
		{
			var clients = await _context.Clients.ToListAsync();
			return clients;
		}

		public async Task<Client> GetClient(int id)
		{
			var client = await _context.Clients.FirstOrDefaultAsync(x => x.Id == id);
			return client;
		}

		public async Task InsertClient(Client client)
		{
			_context.Clients.Add(client);
			await _context.SaveChangesAsync();
		}

		public async Task<bool> UpdateClient(Client client)
		{
			var currentClient = await GetClient(client.Id);
			currentClient.Email = client.Email;
			currentClient.AccidentId = client.AccidentId;
			currentClient.Phone = client.Phone;
			currentClient.Name = client.Name;
			currentClient.CarModel = client.CarModel;
			currentClient.CompanyId = client.CompanyId;

			int rows = await _context.SaveChangesAsync();
			return rows > 0;
		}

		public async Task<bool> DeleteClient(int id)
		{
			var currentClient = await GetClient(id);
			_context.Clients.Remove(currentClient);

			int rows = await _context.SaveChangesAsync();
			return rows > 0;
		}
	}
}
