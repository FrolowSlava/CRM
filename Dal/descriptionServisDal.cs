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
	public class descriptionServisDal : BaseDal<DefaultDbContext, DescriptionServi, Entities.DescriptionServi, int, descriptionServisSearchParams, object>
	{
		protected override bool RequiresUpdatesAfterObjectSaving => false;

		public descriptionServisDal()
		{
		}

		protected internal descriptionServisDal(DefaultDbContext context) : base(context)
		{
		}

		protected override Task UpdateBeforeSavingAsync(DefaultDbContext context, Entities.DescriptionServi entity, DescriptionServi dbObject, bool exists)
		{
			dbObject.DescriptionServisId = entity.DescriptionServisId;
			dbObject.ServisId = entity.ServisId;
			dbObject.OrderId = entity.OrderId;
			dbObject.WorkerId = entity.WorkerId;
			return Task.CompletedTask;
		}
	
		protected override Task<IQueryable<DescriptionServi>> BuildDbQueryAsync(DefaultDbContext context, IQueryable<DescriptionServi> dbObjects, descriptionServisSearchParams searchParams)
		{
			return Task.FromResult(dbObjects);
		}

		protected override async Task<IList<Entities.DescriptionServi>> BuildEntitiesListAsync(DefaultDbContext context, IQueryable<DescriptionServi> dbObjects, object convertParams, bool isFull)
		{
			return (await dbObjects.ToListAsync()).Select(ConvertDbObjectToEntity).ToList();
		}

		protected override Expression<Func<DescriptionServi, int>> GetIdByDbObjectExpression()
		{
			return item => item.DescriptionServisId;
		}

		protected override Expression<Func<Entities.DescriptionServi, int>> GetIdByEntityExpression()
		{
			return item => item.DescriptionServisId;
		}

		internal static Entities.DescriptionServi ConvertDbObjectToEntity(DescriptionServi dbObject)
		{
			return dbObject == null ? null : new Entities.DescriptionServi(dbObject.DescriptionServisId,
				dbObject.ServisId, dbObject.OrderId, dbObject.WorkerId);
		}
	}
}
