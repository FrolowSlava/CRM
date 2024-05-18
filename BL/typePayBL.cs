using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using TypePay = Entities.TypePay;

namespace BL
{
	public class typePayBL
	{
		public async Task<int> AddOrUpdateAsync(TypePay entity)
		{
			entity.TypePayId = await new typePayDal().AddOrUpdateAsync(entity);
			return entity.TypePayId;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new typePayDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(typePaySearchParams searchParams)
		{
			return new typePayDal().ExistsAsync(searchParams);
		}

		public Task<TypePay> GetAsync(int id)
		{
			return new typePayDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new typePayDal().DeleteAsync(id);
		}

		public Task<SearchResult<TypePay>> GetAsync(typePaySearchParams searchParams)
		{
			return new typePayDal().GetAsync(searchParams);
		}
	}
}

