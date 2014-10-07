namespace NinjectStudy.BLL
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
