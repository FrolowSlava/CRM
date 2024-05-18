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
	public class rolesDal : BaseDal<DefaultDbContext, Role, Entities.Role, int, rolesSearchParams, object>
	{
		protected override bool RequiresUpdatesAfterObjectSaving => false;

		public rolesDal()
		{
		}

		protected internal rolesDal(DefaultDbContext context) : base(context)
		{
		}

		protected override Task UpdateBeforeSavingAsync(DefaultDbContext context, Entities.Role entity, Role dbObject, bool exists)
		{
			dbObject.RolesId = entity.RolesId;
			dbObject.RoleName = entity.RoleName;
			dbObject.Salary = entity.Salary;
			return Task.CompletedTask;
		}
	
		protected override Task<IQueryable<Role>> BuildDbQueryAsync(DefaultDbContext context, IQueryable<Role> dbObjects, rolesSearchParams searchParams)
		{
			return Task.FromResult(dbObjects);
		}

		protected override async Task<IList<Entities.Role>> BuildEntitiesListAsync(DefaultDbContext context, IQueryable<Role> dbObjects, object convertParams, bool isFull)
		{
			return (await dbObjects.ToListAsync()).Select(ConvertDbObjectToEntity).ToList();
		}

		protected override Expression<Func<Role, int>> GetIdByDbObjectExpression()
		{
			return item => item.RolesId;
		}

		protected override Expression<Func<Entities.Role, int>> GetIdByEntityExpression()
		{
			return item => item.RolesId;
		}

		internal static Entities.Role ConvertDbObjectToEntity(Role dbObject)
		{
			return dbObject == null ? null : new Entities.Role(dbObject.RolesId, dbObject.RoleName, dbObject.Salary);
		}
	}
}
