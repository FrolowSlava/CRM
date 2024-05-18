using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using Car = Entities.Car;

namespace BL
{
	public class carBL
	{
		public async Task<int> AddOrUpdateAsync(Car entity)
		{
			entity.CarId = await new carDal().AddOrUpdateAsync(entity);
			return entity.CarId;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new carDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(carSearchParams searchParams)
		{
			return new carDal().ExistsAsync(searchParams);
		}

		public Task<Car> GetAsync(int id)
		{
			return new carDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new carDal().DeleteAsync(id);
		}

		public Task<SearchResult<Car>> GetAsync(carSearchParams searchParams)
		{
			return new carDal().GetAsync(searchParams);
		}
	}
}

