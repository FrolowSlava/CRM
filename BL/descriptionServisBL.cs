using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using DescriptionServi = Entities.DescriptionServi;

namespace BL
{
	public class descriptionServisBL
	{
		public async Task<int> AddOrUpdateAsync(DescriptionServi entity)
		{
			entity.DescriptionServisId = await new descriptionServisDal().AddOrUpdateAsync(entity);
			return entity.DescriptionServisId;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new descriptionServisDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(descriptionServisSearchParams searchParams)
		{
			return new descriptionServisDal().ExistsAsync(searchParams);
		}

		public Task<DescriptionServi> GetAsync(int id)
		{
			return new descriptionServisDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new descriptionServisDal().DeleteAsync(id);
		}

		public Task<SearchResult<DescriptionServi>> GetAsync(descriptionServisSearchParams searchParams)
		{
			return new descriptionServisDal().GetAsync(searchParams);
		}
	}
}

