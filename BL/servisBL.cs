using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using Servi = Entities.Servi;

namespace BL
{
	public class servisBL
	{
		public async Task<int> AddOrUpdateAsync(Servi entity)
		{
			entity.ServisId = await new servisDal().AddOrUpdateAsync(entity);
			return entity.ServisId;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new servisDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(servisSearchParams searchParams)
		{
			return new servisDal().ExistsAsync(searchParams);
		}

		public Task<Servi> GetAsync(int id)
		{
			return new servisDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new servisDal().DeleteAsync(id);
		}

		public Task<SearchResult<Servi>> GetAsync(servisSearchParams searchParams)
		{
			return new servisDal().GetAsync(searchParams);
		}
	}
}

