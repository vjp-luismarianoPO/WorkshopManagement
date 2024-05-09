using WorkshopManagement.Core.Interfaces;
using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Infrastructure.Repositories
{
	public class CompanyRepository : ICompanyRepository
	{
		public Task<IEnumerable<Company>> GetCompanies()
		{
			throw new NotImplementedException();
		}

		public Task<Company> GetCompany(int id)
		{
			throw new NotImplementedException();
		}

		public Task InsertCompany(Company company)
		{
			throw new NotImplementedException();
		}
	}
}
