using System;
using System.Data.Entity.Core.Common.CommandTrees;
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
			get { return DataContext.Groups; }
		}

		protected override Group GetSingle(Group entity)
		{
			return EntitySet.FirstOrDefault(group => group.Id == entity.Id);
		}
	}
}