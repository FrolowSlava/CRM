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
	public class workersDal : BaseDal<DefaultDbContext, Worker, Entities.Worker, int, workersSearchParams, object>
	{
		protected override bool RequiresUpdatesAfterObjectSaving => false;

		public workersDal()
		{
		}

		protected internal workersDal(DefaultDbContext context) : base(context)
		{
		}

		protected override Task UpdateBeforeSavingAsync(DefaultDbContext context, Entities.Worker entity, Worker dbObject, bool exists)
		{
			dbObject.WorkerId = entity.WorkerId;
			dbObject.WorkerName = entity.WorkerName;
			dbObject.RolesId = entity.RolesId;
			dbObject.IsBusy = entity.IsBusy;
			return Task.CompletedTask;
		}
	
		protected override Task<IQueryable<Worker>> BuildDbQueryAsync(DefaultDbContext context, IQueryable<Worker> dbObjects, workersSearchParams searchParams)
		{
			return Task.FromResult(dbObjects);
		}

		protected override async Task<IList<Entities.Worker>> BuildEntitiesListAsync(DefaultDbContext context, IQueryable<Worker> dbObjects, object convertParams, bool isFull)
		{
			return (await dbObjects.ToListAsync()).Select(ConvertDbObjectToEntity).ToList();
		}

		protected override Expression<Func<Worker, int>> GetIdByDbObjectExpression()
		{
			return item => item.WorkerId;
		}

		protected override Expression<Func<Entities.Worker, int>> GetIdByEntityExpression()
		{
			return item => item.WorkerId;
		}

		internal static Entities.Worker ConvertDbObjectToEntity(Worker dbObject)
		{
			return dbObject == null ? null : new Entities.Worker(dbObject.WorkerId, dbObject.WorkerName,
				dbObject.RolesId, dbObject.IsBusy);
		}
	}
}
