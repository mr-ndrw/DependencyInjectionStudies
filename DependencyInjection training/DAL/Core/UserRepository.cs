using System;
using System.Linq;
using NinjectStudy.BLL.Entities;
using NinjectStudy.DAL.Interfaces;

namespace NinjectStudy.DAL
{
	public class UserRepository : RepositoryBase<User>, IUserRepository
	{
		public UserRepository(IFlowPostDataContext dataContext)
			: base(dataContext)
		{
		}

		/// <summary>
		///     Set containing Entities typed with current repository.
		/// </summary>
		protected override IQueryable<User> EntitySet
		{
			get { return DataContext.Users; }
		}

		/// <summary>
		/// </summary>
		/// <param name="entity">Entity to be found.</param>
		/// <returns>Found entity.</returns>
		protected override User GetSingle(User entity)
		{
			return EntitySet.FirstOrDefault(user => user.Id == entity.Id);
		}
	}
}