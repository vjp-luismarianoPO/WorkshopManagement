using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WorkshopManagement.Core.DTOs;
using WorkshopManagement.Core.Interfaces;
using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClientController : ControllerBase
	{
		private readonly IClientRepository _clientRepository;
		private readonly IMapper _mapper;

		public ClientController(IClientRepository clientRepository, IMapper mapper)
		{
			_clientRepository = clientRepository;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<IActionResult> GetClients()
		{
			var clients = await _clientRepository.GetClients();
			var clientsDto = _mapper.Map<IEnumerable<ClientDto>>(clients);
			return Ok(clientsDto);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetClient(int id)
		{
			var client = await _clientRepository.GetClient(id);
			var clientsDto = _mapper.Map<ClientDto>(client);
			return Ok(clientsDto);
		}

		[HttpPost]
		public async Task<IActionResult> InsertClient(ClientDto clientDto)
		{
			var client = _mapper.Map<Client>(clientDto);

			await _clientRepository.InsertClient(client);
			return Ok(client);
		}
	}
}
