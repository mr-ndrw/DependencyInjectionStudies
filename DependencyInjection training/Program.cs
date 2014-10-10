using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Ninject;
using NinjectStudy.BLL.Entities;
using NinjectStudy.BLL.Interfaces;
using NinjectStudy.DAL;

namespace NinjectStudy
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IKernel kernel = new StandardKernel();
			kernel.Load(Assembly.GetExecutingAssembly());

			IFlowPostServices services = kernel.Get<IFlowPostServices>();

			User thomas = new User
			{
				Name = "Thomas"
			};

			services.UserService.Insert(thomas, true);

			var users = services.UserService.GetAll();

			foreach (var user in users)
			{
				Console.WriteLine(user.Name);
			}
			Console.ReadKey();
		}
	}
}