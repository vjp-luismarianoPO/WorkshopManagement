using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WorkshopManagement.Core.DTOs;
using WorkshopManagement.Core.Interfaces;
using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccidentController : ControllerBase
	{
		private readonly IAccidentRepository _accidentRepository;
		private readonly IMapper _mapper;

		public AccidentController(IAccidentRepository accidentRepository, IMapper mapper)
		{
			_accidentRepository = accidentRepository;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<IActionResult> GetAccidents()
		{
			var accidents = await _accidentRepository.GetAccidents();
			var accidentsDto = _mapper.Map<IEnumerable<AccidentDto>>(accidents);
			return Ok(accidentsDto);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetAccident(int id)
		{
			var accident = await _accidentRepository.GetAccident(id);
			var accidentDto = _mapper.Map<AccidentDto>(accident);
			return Ok(accidentDto);
		}

		[HttpPost]
		public async Task<IActionResult> Accident(AccidentDto accidentDto)
		{
			var accident = _mapper.Map<Accident>(accidentDto);

			await _accidentRepository.InsertAccident(accident);
			return Ok(accident);
		}

	}
}
