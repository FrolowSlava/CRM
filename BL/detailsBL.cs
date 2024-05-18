using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using Detail = Entities.Detail;

namespace BL
{
	public class detailsBL
	{
		public async Task<int> AddOrUpdateAsync(Detail entity)
		{
			entity.DetailId = await new detailsDal().AddOrUpdateAsync(entity);
			return entity.DetailId;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new detailsDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(detailsSearchParams searchParams)
		{
			return new detailsDal().ExistsAsync(searchParams);
		}

		public Task<Detail> GetAsync(int id)
		{
			return new detailsDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new detailsDal().DeleteAsync(id);
		}

		public Task<SearchResult<Detail>> GetAsync(detailsSearchParams searchParams)
		{
			return new detailsDal().GetAsync(searchParams);
		}
	}
}

