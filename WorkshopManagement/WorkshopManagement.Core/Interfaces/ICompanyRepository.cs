using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Core.Interfaces
{
	public interface ICompanyRepository
	{
		Task<IEnumerable<Company>> GetCompanies();
		Task<Company> GetCompany(int id);
		Task InsertCompany(Company company);
	}
}
