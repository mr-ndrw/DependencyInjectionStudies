using NinjectStudy.BLL.Interfaces;

namespace NinjectStudy.BLL.Core
{
	class FlowPostServices : IFlowPostServices
	{
		public FlowPostServices(IUserService userService)
		{
			UserService = userService;
		}

		public IUserService UserService { get; set; }
	}
}
