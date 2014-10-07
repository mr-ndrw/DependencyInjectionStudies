using System;
using System.Linq;
using NinjectStudy.BLL;

namespace NinjectStudy.DAL
{
	public class UserRepository : RepositoryBase<User>, IUserRepository
	{
		public UserRepository(IFlowPostDataContext dataContext)
			: base(dataContext)
		{
		}
		/// <summary>
		///		
		/// </summary>
		/// <param name="entity">Entity to be found.</param>
		/// <returns>Found entity.</returns>
		protected override User GetSingle(User entity)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///		Set containing Entities typed with current repository.
		/// </summary>
		protected override IQueryable<User> EntitySet
		{
			get { throw new NotImplementedException(); }
		}
	}
}
