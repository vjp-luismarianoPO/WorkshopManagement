using AutoMapper;
using WorkshopManagement.Core.DTOs;
using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Infrastructure.Mappings
{
	public class AutomapperProfile : Profile
	{
		public AutomapperProfile()
		{
			CreateMap<Accident, AccidentDto>();
			CreateMap<AccidentDto, Accident>();
			CreateMap<CompanyDto, Company>();
			CreateMap<Company, CompanyDto>();
			CreateMap<SupplierDto, Supplier>();
			CreateMap<Supplier, SupplierDto>();
			CreateMap<ClientDto, Client>();
			CreateMap<Client, ClientDto>();
		}
	}
}
