using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Core.Interfaces
{
	public interface ISupplierRepository
	{
		Task<IEnumerable<Supplier>> GetSuppliers();
		Task<Supplier> GetSupplier(int id);
		Task InsertSupplier(Supplier supplier);
	}
}
