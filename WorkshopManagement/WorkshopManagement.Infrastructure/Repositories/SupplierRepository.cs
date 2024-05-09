using WorkshopManagement.Core.Interfaces;
using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Infrastructure.Repositories
{
	public class SupplierRepository : ISupplierRepository
	{
		public Task<Supplier> GetSupplier(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Supplier>> GetSuppliers()
		{
			throw new NotImplementedException();
		}

		public Task InsertSupplier(Supplier supplier)
		{
			throw new NotImplementedException();
		}
	}
}
