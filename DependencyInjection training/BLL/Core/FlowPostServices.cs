using NinjectStudy.BLL.Interfaces;

namespace NinjectStudy.BLL.Core
{
	class FlowPostServices : IFlowPostServices
	{
		public FlowPostServices(IUserService userService, IGroupService groupService)
		{
			UserService = userService;
			GroupService = groupService;
		}

		public IUserService UserService { get; set; }
		public IGroupService GroupService { get; set; }
	}
}
