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
	public class typePayDal : BaseDal<DefaultDbContext, TypePay, Entities.TypePay, int, typePaySearchParams, object>
	{
		protected override bool RequiresUpdatesAfterObjectSaving => false;

		public typePayDal()
		{
		}

		protected internal typePayDal(DefaultDbContext context) : base(context)
		{
		}

		protected override Task UpdateBeforeSavingAsync(DefaultDbContext context, Entities.TypePay entity, TypePay dbObject, bool exists)
		{
			dbObject.TypePayId = entity.TypePayId;
			dbObject.ByCash = entity.ByCash;
			dbObject.ByCard = entity.ByCard;
			return Task.CompletedTask;
		}
	
		protected override Task<IQueryable<TypePay>> BuildDbQueryAsync(DefaultDbContext context, IQueryable<TypePay> dbObjects, typePaySearchParams searchParams)
		{
			return Task.FromResult(dbObjects);
		}

		protected override async Task<IList<Entities.TypePay>> BuildEntitiesListAsync(DefaultDbContext context, IQueryable<TypePay> dbObjects, object convertParams, bool isFull)
		{
			return (await dbObjects.ToListAsync()).Select(ConvertDbObjectToEntity).ToList();
		}

		protected override Expression<Func<TypePay, int>> GetIdByDbObjectExpression()
		{
			return item => item.TypePayId;
		}

		protected override Expression<Func<Entities.TypePay, int>> GetIdByEntityExpression()
		{
			return item => item.TypePayId;
		}

		internal static Entities.TypePay ConvertDbObjectToEntity(TypePay dbObject)
		{
			return dbObject == null ? null : new Entities.TypePay(dbObject.TypePayId, dbObject.ByCash, dbObject.ByCard);
		}
	}
}
