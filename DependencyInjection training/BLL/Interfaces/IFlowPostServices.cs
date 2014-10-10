namespace NinjectStudy.BLL.Interfaces
{
	public interface IFlowPostServices
	{
		IUserService UserService { get; set; }
		IGroupService GroupService { get; set; }
	}
}
