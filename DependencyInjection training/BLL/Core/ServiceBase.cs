using System;
using System.Linq;
using System.Linq.Expressions;
using NinjectStudy.BLL.Interfaces;
using NinjectStudy.DAL.Interfaces;

namespace NinjectStudy.BLL.Core
{
	public abstract class ServiceBase<T> : IService<T> where T : class
	{
		protected IRepository<T> repository { get; set; } 

		/// <summary>
		///		Add an entity to the repository.
		/// </summary>
		/// <param name="entity">
		///		Entity to add.
		/// </param>
		/// <param name="commit">
		///		
		/// </param>
		public void Insert(T entity, bool commit)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///		Deletes selected entity from the repository.
		/// </summary>
		/// <param name="entity">
		///		Entity to be deleted.
		/// </param>
		public void Delete(T entity, bool commit)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///		Updates selected entity in the repository.
		/// </summary>
		/// <param name="entity">
		///		Entity to be updated.
		/// </param>
		public void Update(T entity, bool commit)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///		Returns First or Default entity matching the expression.
		/// </summary>
		/// <param name="predicate">
		///		Criteria for searching.
		/// </param>
		/// <returns>
		///		First or Default matching Entity.
		/// </returns>
		public T GetSingle(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///		Returns all existing entities in the respository.
		/// </summary>
		/// <returns>
		///		All existing entities.
		/// </returns>
		public IQueryable<T> GetAll()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///		Returns all entities which match the given expression/
		/// </summary>
		/// <param name="predicate">
		///		Criteria for searching/
		/// </param>
		/// <returns>
		///		All matching entities.
		/// </returns>
		public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///		Returns the total number of entities existing in the repository.
		/// </summary>
		/// <returns>
		///		Total number of entities.
		/// </returns>
		public long Count()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///		Returns the total number of entities which match the given expression in the repository.
		/// </summary>
		/// <param name="predicate">
		///		Criteria for search.
		/// </param>
		/// <returns>
		///		Total number of entities which match the given criteria.
		/// </returns>
		public long Count(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///		Queries the repository for the entities which match the predicate.
		/// </summary>
		/// <param name="predicate">
		///		Criteria for search.
		/// </param>
		/// <returns>
		///		Found entities Queryable.
		/// </returns>
		public IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}
	}
}
