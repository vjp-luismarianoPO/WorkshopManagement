using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkshopManagement.Core.Interfaces;
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

		//public AccidentController(IAccidentService accidentService)
		//{
		//	_accidentService = accidentService;
		//}

		//[HttpGet]
		//public async Task<ActionResult<IEnumerable<Accident>>> GetAllAccidents()
		//{
		//	try
		//	{
		//		var accidents = await _accidentService.GetAllAccidents();
		//		return Ok(accidents);
		//	}
		//	catch (Exception ex)
		//	{
		//		return StatusCode(500, $"Internal server error: {ex.Message}");
		//	}
		//}

		//[HttpGet("{id}")]
		//public async Task<ActionResult<Accident>> GetAccidentById(int id)
		//{
		//	try
		//	{
		//		var accident = await _accidentService.GetAccidentById(id);
		//		if (accident == null)
		//		{
		//			return NotFound();
		//		}
		//		return Ok(accident);
		//	}
		//	catch (Exception ex)
		//	{
		//		return StatusCode(500, $"Internal server error: {ex.Message}");
		//	}
		//}

		//[HttpPost]
		//public async Task<ActionResult> AddAccident(Accident accident)
		//{
		//	await _accidentService.AddAccident(accident);

		//	var response = new ApiResponse<Accident>(accident);
		//	return Ok(response);
		//}
	}
}
