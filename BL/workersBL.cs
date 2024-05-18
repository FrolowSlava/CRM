using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using Worker = Entities.Worker;

namespace BL
{
	public class workersBL
	{
		public async Task<int> AddOrUpdateAsync(Worker entity)
		{
			entity.WorkerId = await new workersDal().AddOrUpdateAsync(entity);
			return entity.WorkerId;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new workersDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(workersSearchParams searchParams)
		{
			return new workersDal().ExistsAsync(searchParams);
		}

		public Task<Worker> GetAsync(int id)
		{
			return new workersDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new workersDal().DeleteAsync(id);
		}

		public Task<SearchResult<Worker>> GetAsync(workersSearchParams searchParams)
		{
			return new workersDal().GetAsync(searchParams);
		}
	}
}

