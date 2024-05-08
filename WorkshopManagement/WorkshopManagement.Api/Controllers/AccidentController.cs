using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkshopManagement.Core.Interfaces;
using WorkshopManagement.Infrastructure.Data;
using WorkshopManagement.Infrastructure.Repositories;

namespace WorkshopManagement.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccidentController : ControllerBase
	{
		//private readonly IAccidentService _accidentService;
		private readonly IAccidentRepository _accidentRepository;

		public AccidentController(IAccidentRepository accidentRepository)
		{
			_accidentRepository = accidentRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetAccidents()
		{
			var accident = await _accidentRepository.GetAccidents();
			return Ok(accident);
		}

		[HttpPost]
		public async Task<IActionResult> Accident(Accident accident)
		{
			await _accidentRepository.InsertAccident(accident);
			return Ok(accident);
		}

	}
}
