using Ninject.Modules;
using NinjectStudy.BLL;
using NinjectStudy.DAL;

namespace NinjectStudy.Ninject
{
	public class Bindings : NinjectModule
	{
		/// <summary>
		/// Loads the module into the kernel.
		/// </summary>
		public override void Load()
		{
			Bind<IFlowPostDataContext>().To<FlowPostDataContext>();
			Bind<IUserRepository>().To<UserRepository>();
			Bind<IUserService>().To<UserService>();
			Bind<IFlowPostServices>().To<FlowPostServices>();
		}
	}
}
