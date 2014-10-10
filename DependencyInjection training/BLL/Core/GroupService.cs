
using NinjectStudy.BLL.Entities;
using NinjectStudy.BLL.Interfaces;
using NinjectStudy.DAL.Interfaces;

namespace NinjectStudy.BLL.Core
{
	public class GroupService : ServiceBase<Group>, IGroupService
	{
		public GroupService(IGroupRepository groupRepository)
		{
			repository = groupRepository;
		}
	}
}
