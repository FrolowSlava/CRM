using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Common.Enums;
using Common.Search;
using Dal.DbModels;

namespace Dal
{
	public class carDal : BaseDal<DefaultDbContext, Car, Entities.Car, int, carSearchParams, object>
	{
		protected override bool RequiresUpdatesAfterObjectSaving => false;

		public carDal()
		{
		}

		protected internal carDal(DefaultDbContext context) : base(context)
		{
		}

		protected override Task UpdateBeforeSavingAsync(DefaultDbContext context, Entities.Car entity, Car dbObject, bool exists)
		{
			dbObject.CarId = entity.CarId;
			dbObject.ClientId = entity.ClientId;
			dbObject.Model = entity.Model;
			dbObject.Year = entity.Year;
			dbObject.Mileage = entity.Mileage;
			return Task.CompletedTask;
		}
	
		protected override Task<IQueryable<Car>> BuildDbQueryAsync(DefaultDbContext context, IQueryable<Car> dbObjects, carSearchParams searchParams)
		{
			return Task.FromResult(dbObjects);
		}

		protected override async Task<IList<Entities.Car>> BuildEntitiesListAsync(DefaultDbContext context, IQueryable<Car> dbObjects, object convertParams, bool isFull)
		{
			return (await dbObjects.ToListAsync()).Select(ConvertDbObjectToEntity).ToList();
		}

		protected override Expression<Func<Car, int>> GetIdByDbObjectExpression()
		{
			return item => item.CarId;
		}

		protected override Expression<Func<Entities.Car, int>> GetIdByEntityExpression()
		{
			return item => item.CarId;
		}

		internal static Entities.Car ConvertDbObjectToEntity(Car dbObject)
		{
			return dbObject == null ? null : new Entities.Car(dbObject.CarId, dbObject.ClientId, dbObject.Model,
				dbObject.Year, dbObject.Mileage);
		}
	}
}
