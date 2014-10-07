using NinjectStudy.DAL;

namespace NinjectStudy.BLL
{
	public class UserService : ServiceBase<User>, IUserService
	{
		public UserService(IUserRepository userRepository)
		{
			repository = userRepository;
		}

	}
}
