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
	}
}
