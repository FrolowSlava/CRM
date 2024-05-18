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
	public class detailsDal : BaseDal<DefaultDbContext, Detail, Entities.Detail, int, detailsSearchParams, object>
	{
		protected override bool RequiresUpdatesAfterObjectSaving => false;

		public detailsDal()
		{
		}

		protected internal detailsDal(DefaultDbContext context) : base(context)
		{
		}

		protected override Task UpdateBeforeSavingAsync(DefaultDbContext context, Entities.Detail entity, Detail dbObject, bool exists)
		{
			dbObject.DetailId = entity.DetailId;
			dbObject.DetailName = entity.DetailName;
			dbObject.Price = entity.Price;
			dbObject.Count = entity.Count;
			return Task.CompletedTask;
		}
	
		protected override Task<IQueryable<Detail>> BuildDbQueryAsync(DefaultDbContext context, IQueryable<Detail> dbObjects, detailsSearchParams searchParams)
		{
			return Task.FromResult(dbObjects);
		}

		protected override async Task<IList<Entities.Detail>> BuildEntitiesListAsync(DefaultDbContext context, IQueryable<Detail> dbObjects, object convertParams, bool isFull)
		{
			return (await dbObjects.ToListAsync()).Select(ConvertDbObjectToEntity).ToList();
		}

		protected override Expression<Func<Detail, int>> GetIdByDbObjectExpression()
		{
			return item => item.DetailId;
		}

		protected override Expression<Func<Entities.Detail, int>> GetIdByEntityExpression()
		{
			return item => item.DetailId;
		}

		internal static Entities.Detail ConvertDbObjectToEntity(Detail dbObject)
		{
			return dbObject == null ? null : new Entities.Detail(dbObject.DetailId, dbObject.DetailName,
				dbObject.Price, dbObject.Count);
		}
	}
}
