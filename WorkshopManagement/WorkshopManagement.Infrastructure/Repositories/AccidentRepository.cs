using Microsoft.EntityFrameworkCore;
using WorkshopManagement.Core.Interfaces;
using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Infrastructure.Repositories
{
	public class AccidentRepository : IAccidentRepository
	{
		private readonly WorkshopManagementDbContext _context;
		public AccidentRepository(WorkshopManagementDbContext context)
		{
			_context = context;

		}
		public async Task<IEnumerable<Accident>> GetAccidents()
		{
			var accidents = await _context.Accidents.ToListAsync();
			return accidents;
		}

		public async Task<Accident> GetAccident(int id)
		{
			var accident = await _context.Accidents.FirstOrDefaultAsync(x => x.Id == id);
			return accident;
		}

		public async Task InsertAccident(Accident accident)
		{
			_context.Accidents.Add(accident);
			await _context.SaveChangesAsync();
		}

		public async Task<bool> UpdateAccident(Accident accident)
		{
			var currentAccident = await GetAccident(accident.Id);
			currentAccident.Type = accident.Type;
			currentAccident.Date = accident.Date;
			currentAccident.SupplierId = accident.SupplierId;
			currentAccident.CompanyId = accident.CompanyId;
			currentAccident.TotalAmount = accident.TotalAmount;
			currentAccident.ClientId = accident.ClientId;

			int rows = await _context.SaveChangesAsync();
			return rows > 0;

		}

		public async Task<bool> DeleteAccident(int id)
		{
			var currentAccident = await GetAccident(id);
			_context.Accidents.Remove(currentAccident);

			int rows = await _context.SaveChangesAsync();
			return rows > 0;

		}


	}
}
