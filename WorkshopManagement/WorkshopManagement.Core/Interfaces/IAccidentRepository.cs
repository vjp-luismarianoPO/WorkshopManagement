using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManagement.Core.Entities;

namespace WorkshopManagement.Core.Interfaces
{
	public interface IAccidentRepository 
	{
		Task<IEnumerable<Accident>> GetAccidents();
	}
}
