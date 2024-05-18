using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using Role = Entities.Role;

namespace BL
{
	public class rolesBL
	{
		public async Task<int> AddOrUpdateAsync(Role entity)
		{
			entity.RolesId = await new rolesDal().AddOrUpdateAsync(entity);
			return entity.RolesId;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new rolesDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(rolesSearchParams searchParams)
		{
			return new rolesDal().ExistsAsync(searchParams);
		}

		public Task<Role> GetAsync(int id)
		{
			return new rolesDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new rolesDal().DeleteAsync(id);
		}

		public Task<SearchResult<Role>> GetAsync(rolesSearchParams searchParams)
		{
			return new rolesDal().GetAsync(searchParams);
		}
	}
}

