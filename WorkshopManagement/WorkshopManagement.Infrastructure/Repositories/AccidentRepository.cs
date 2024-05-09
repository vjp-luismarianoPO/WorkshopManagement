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
	}
}
