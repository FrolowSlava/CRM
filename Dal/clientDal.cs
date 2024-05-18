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
	public class clientDal : BaseDal<DefaultDbContext, Client, Entities.Client, int, clientSearchParams, object>
	{
		protected override bool RequiresUpdatesAfterObjectSaving => false;

		public clientDal()
		{
		}

		protected internal clientDal(DefaultDbContext context) : base(context)
		{
		}

		protected override Task UpdateBeforeSavingAsync(DefaultDbContext context, Entities.Client entity, Client dbObject, bool exists)
		{
			dbObject.ClientId = entity.ClientId;
			dbObject.Name = entity.Name;
			dbObject.Phone = entity.Phone;
			dbObject.Order = entity.Order;
			dbObject.SpentSum = entity.SpentSum;
			dbObject.BonusLevel = entity.BonusLevel;
			return Task.CompletedTask;
		}
	
		protected override Task<IQueryable<Client>> BuildDbQueryAsync(DefaultDbContext context, IQueryable<Client> dbObjects, clientSearchParams searchParams)
		{
			return Task.FromResult(dbObjects);
		}

		protected override async Task<IList<Entities.Client>> BuildEntitiesListAsync(DefaultDbContext context, IQueryable<Client> dbObjects, object convertParams, bool isFull)
		{
			return (await dbObjects.ToListAsync()).Select(ConvertDbObjectToEntity).ToList();
		}

		protected override Expression<Func<Client, int>> GetIdByDbObjectExpression()
		{
			return item => item.ClientId;
		}

		protected override Expression<Func<Entities.Client, int>> GetIdByEntityExpression()
		{
			return item => item.ClientId;
		}

		internal static Entities.Client ConvertDbObjectToEntity(Client dbObject)
		{
			return dbObject == null ? null : new Entities.Client(dbObject.ClientId, dbObject.Name, dbObject.Phone,
				dbObject.Order, dbObject.SpentSum, dbObject.BonusLevel);
		}
	}
}
