﻿using WorkshopManagement.Infrastructure.Data;

namespace WorkshopManagement.Core.Interfaces
{
	public interface IAccidentRepository
	{
		Task<IEnumerable<Accident>> GetAccidents();
		Task<Accident> GetAccident(int id);
		Task InsertAccident(Accident accident);
		Task<bool> UpdateAccident(Accident accident);
		Task<bool> DeleteAccident(int id);

	}
}
