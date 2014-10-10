using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Security.Cryptography.X509Certificates;
using NinjectStudy.BLL.Entities;

namespace NinjectStudy.DAL.Interfaces
{
	public interface IFlowPostDataContext : IDisposable
	{
		DbSet<TEntity> Set<TEntity>() where TEntity : class;
		DbSet Set(Type entityType);
		IEnumerable<DbEntityValidationResult> GetValidationErrors();
		DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
		DbEntityEntry Entry(object entity);
		int SaveChanges();
		DbSet<User> Users { get; set; }
		DbSet<Group> Groups { get; set; }

	}
}
