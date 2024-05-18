using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using Client = Entities.Client;

namespace BL
{
	public class clientBL
	{
		public async Task<int> AddOrUpdateAsync(Client entity)
		{
			entity.ClientId = await new clientDal().AddOrUpdateAsync(entity);
			return entity.ClientId;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new clientDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(clientSearchParams searchParams)
		{
			return new clientDal().ExistsAsync(searchParams);
		}

		public Task<Client> GetAsync(int id)
		{
			return new clientDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new clientDal().DeleteAsync(id);
		}

		public Task<SearchResult<Client>> GetAsync(clientSearchParams searchParams)
		{
			return new clientDal().GetAsync(searchParams);
		}
	}
}

