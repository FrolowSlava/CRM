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
	public class detailsOnOrderDal : BaseDal<DefaultDbContext, DetailsOnOrder, Entities.DetailsOnOrder, int, detailsOnOrderSearchParams, object>
	{
		protected override bool RequiresUpdatesAfterObjectSaving => false;

		public detailsOnOrderDal()
		{
		}

		protected internal detailsOnOrderDal(DefaultDbContext context) : base(context)
		{
		}

		protected override Task UpdateBeforeSavingAsync(DefaultDbContext context, Entities.DetailsOnOrder entity, DetailsOnOrder dbObject, bool exists)
		{
			dbObject.DetailId = entity.DetailId;
			dbObject.OrderId = entity.OrderId;
			dbObject.Count = entity.Count;
			return Task.CompletedTask;
		}
	
		protected override Task<IQueryable<DetailsOnOrder>> BuildDbQueryAsync(DefaultDbContext context, IQueryable<DetailsOnOrder> dbObjects, detailsOnOrderSearchParams searchParams)
		{
			return Task.FromResult(dbObjects);
		}

		protected override async Task<IList<Entities.DetailsOnOrder>> BuildEntitiesListAsync(DefaultDbContext context, IQueryable<DetailsOnOrder> dbObjects, object convertParams, bool isFull)
		{
			return (await dbObjects.ToListAsync()).Select(ConvertDbObjectToEntity).ToList();
		}

		protected override Expression<Func<DetailsOnOrder, int>> GetIdByDbObjectExpression()
		{
			return item => item.DetailId;
		}

		protected override Expression<Func<Entities.DetailsOnOrder, int>> GetIdByEntityExpression()
		{
			return item => item.DetailId;
		}

		internal static Entities.DetailsOnOrder ConvertDbObjectToEntity(DetailsOnOrder dbObject)
		{
			return dbObject == null ? null : new Entities.DetailsOnOrder(dbObject.DetailId, dbObject.OrderId,
				dbObject.Count);
		}
	}
}
