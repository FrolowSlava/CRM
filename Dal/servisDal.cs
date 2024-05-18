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
	public class servisDal : BaseDal<DefaultDbContext, Servi, Entities.Servi, int, servisSearchParams, object>
	{
		protected override bool RequiresUpdatesAfterObjectSaving => false;

		public servisDal()
		{
		}

		protected internal servisDal(DefaultDbContext context) : base(context)
		{
		}

		protected override Task UpdateBeforeSavingAsync(DefaultDbContext context, Entities.Servi entity, Servi dbObject, bool exists)
		{
			dbObject.ServisId = entity.ServisId;
			dbObject.Name = entity.Name;
			dbObject.Price = entity.Price;
			dbObject.ExecutionTime = entity.ExecutionTime;
			return Task.CompletedTask;
		}
	
		protected override Task<IQueryable<Servi>> BuildDbQueryAsync(DefaultDbContext context, IQueryable<Servi> dbObjects, servisSearchParams searchParams)
		{
			return Task.FromResult(dbObjects);
		}

		protected override async Task<IList<Entities.Servi>> BuildEntitiesListAsync(DefaultDbContext context, IQueryable<Servi> dbObjects, object convertParams, bool isFull)
		{
			return (await dbObjects.ToListAsync()).Select(ConvertDbObjectToEntity).ToList();
		}

		protected override Expression<Func<Servi, int>> GetIdByDbObjectExpression()
		{
			return item => item.ServisId;
		}

		protected override Expression<Func<Entities.Servi, int>> GetIdByEntityExpression()
		{
			return item => item.ServisId;
		}

		internal static Entities.Servi ConvertDbObjectToEntity(Servi dbObject)
		{
			return dbObject == null ? null : new Entities.Servi(dbObject.ServisId, dbObject.Name, dbObject.Price,
				dbObject.ExecutionTime);
		}
	}
}
