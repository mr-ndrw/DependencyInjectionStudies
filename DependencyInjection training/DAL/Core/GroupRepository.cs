using System;
using System.Linq;
using NinjectStudy.BLL.Entities;
using NinjectStudy.DAL.Interfaces;

namespace NinjectStudy.DAL
{
	public class GroupRepository : RepositoryBase<Group>, IGroupRepository
	{
		public GroupRepository(IFlowPostDataContext dataContext)
			: base(dataContext)
		{
		}

		protected override IQueryable<Group> EntitySet
		{
			get { throw new NotImplementedException(); }
		}

		protected override Group GetSingle(Group entity)
		{
			throw new NotImplementedException();
		}
	}
}