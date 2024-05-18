using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using DetailsOnOrder = Entities.DetailsOnOrder;

namespace BL
{
	public class detailsOnOrderBL
	{
		public async Task<int> AddOrUpdateAsync(DetailsOnOrder entity)
		{
			entity.DetailId = await new detailsOnOrderDal().AddOrUpdateAsync(entity);
			return entity.DetailId;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new detailsOnOrderDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(detailsOnOrderSearchParams searchParams)
		{
			return new detailsOnOrderDal().ExistsAsync(searchParams);
		}

		public Task<DetailsOnOrder> GetAsync(int id)
		{
			return new detailsOnOrderDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new detailsOnOrderDal().DeleteAsync(id);
		}

		public Task<SearchResult<DetailsOnOrder>> GetAsync(detailsOnOrderSearchParams searchParams)
		{
			return new detailsOnOrderDal().GetAsync(searchParams);
		}
	}
}

