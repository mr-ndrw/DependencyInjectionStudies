using NinjectStudy.BLL.Entities;
using NinjectStudy.BLL.Interfaces;
using NinjectStudy.DAL.Interfaces;

namespace NinjectStudy.BLL.Core
{
	public class UserService : ServiceBase<User>, IUserService
	{
		public UserService(IUserRepository userRepository)
		{
			repository = userRepository;
		}

	}
}
